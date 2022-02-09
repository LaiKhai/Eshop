using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eshop_Bookstore.Data;
using Eshop_Bookstore.Models;
using Eshop_Bookstore.Helpers;
using Microsoft.AspNetCore.Http;

namespace Eshop_Bookstore.Controllers
{
    public class CartsController : Controller
    {
        private readonly Eshop_BookstoreContext _context;

        public CartsController(Eshop_BookstoreContext context)
        {
            _context = context;
        }
        //Tạo danh sách Giỏ Hàng

        public List<Cart> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<Cart>>("GioHang");
                if (data == null)
                {
                    data = new List<Cart>();
                }
                
                return data;
            }
        }

        //End - Tạo danh sách giỏ hàng

        //Kiểm tra giỏ hàng
        public async Task<bool> CheckCart()
        {
            //  Start: Kiểm tra user xem đã đăng nhập chưa
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                var id = HttpContext.Session.GetString("IdAccount");
                // lấy danh sách sản phẩm của tài khoản
                var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == Int32.Parse(id));
                //end - lấy danh sách sản phẩm của tài khoản
                if (cart == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        //End - Kiêm tra giỏ hàng
        //Thêm giỏ hàng
        public async Task<IActionResult> AddToCart(int id,int quantity)
        {
            var idAccount = HttpContext.Session.GetString("IdAccount");
            if (idAccount == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                    //var myCart = Carts;
                    var item = _context.Carts.SingleOrDefault(p => p.ProductId == id);
                    if (item == null)
                    {
                        var product = _context.Products.SingleOrDefault(p => p.Id == id);
                        
                        item = new Cart
                        {
                            AccountId = Int32.Parse(idAccount)+1,
                            ProductId = id,
                            Product = product,
                            Quantity = quantity
                        };
                        //myCart.Add(item);
                    _context.Add(item);
                }
                    else
                    {
                        item.Quantity += quantity;
                    }
                    //HttpContext.Session.Set("GioHang", myCart);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index","Cart");
            }
                    
        }
        //End - Thêm giỏ hàng
        // GET: Carts
        public async Task<IActionResult> Index(int? id)
        {
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                var userLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
                ViewBag.UserLogin = userLogin;
                var cart = await _context.Carts.Include(c=>c.Product)
                .Where(m => m.AccountId == id).ToListAsync();
                return View(cart);
            }
            else
            {
                ViewBag.UserLogin = null;
            }
            //  End: Kiểm tra user xem đã đăng nhập chưa
            return RedirectToAction("Login", "Home");
        }
        
        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", cart.ProductId);
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", cart.ProductId);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", cart.ProductId);
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
    }
}
