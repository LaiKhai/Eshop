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

        //Thêm giỏ hàng
        public async Task<IActionResult> AddToCart(int id, int quantity)
        {
            Cart giohang = _context.Carts.FirstOrDefault(gh => gh.ProductId == id);
            if (giohang == null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserID");
                giohang = new Cart()
                {
                    AccountId = UserId,
                    ProductId = id,
                    Quantity = quantity
                };
                _context.Carts.Add(giohang);
                await _context.SaveChangesAsync();
            }
            else
            {
                giohang.Quantity += quantity;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

    
        //End - Thêm giỏ hàng
        // GET: Carts
        public async Task<IActionResult> Index()
        {

        // Start: Kiểm tra user xem đã đăng nhập chưa
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                var userLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
                ViewBag.UserLogin = userLogin;
                ViewData["Total"] = _context.Carts.Sum(p => p.Quantity * p.Product.Price);
                int UserId = (int)HttpContext.Session.GetInt32("UserID");
                var sp = _context.Carts.Include(p => p.Product).Include(u => u.Account).Where(i => i.AccountId == UserId);
                return View(await sp.ToListAsync());
            }
            else
            {
                ViewBag.UserLogin = null;
                return RedirectToAction("Login", "Home");
            }
            //  End: Kiểm tra user xem đã đăng nhập chưa
            
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
            var gioHang = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(gioHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateToCart(int? id, int soluong)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sp = await _context.Carts.FirstOrDefaultAsync(p => p.ProductId == id);
            if (soluong > 0)
            {
                sp.Quantity = soluong;
                _context.Update(sp);
            }
            else if (soluong < 0)
            {
                sp.Quantity = 1;
                _context.Update(sp);
            }
            else if (soluong == 0)
            {
                _context.Remove(sp);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
        public IActionResult Pay()
        {
            // Start: Kiểm tra user xem đã đăng nhập chưa
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                ViewData["Account"] = _context.Accounts.Where(a => a.Username == username).FirstOrDefault();
                int UserId = (int)HttpContext.Session.GetInt32("UserID");
                ViewData["Total"] = _context.Carts.Include(p => p.Product).Include(a => a.Account).Where(s => s.Account.Username == username).Sum(p => p.Quantity * p.Product.Price);
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            //  End: Kiểm tra user xem đã đăng nhập chưa
            
        }
        [HttpPost]
        public IActionResult Pay([Bind("ShippingAddress,ShippingPhone")] Invoice inv)
        {
            var username = HttpContext.Session.GetString("username");
            if (!checkCart(username))
            {
                ViewBag.ErrorMessage = "Có sản phẩm đã hết hàng. Vui lòng kiểm tra !";
                return View();
            }
            //Thêm hóa đơn
            DateTime now = DateTime.Now;
            inv.Code = now.ToString("yyMMddhhmmss");
            inv.AccoutId = _context.Accounts.FirstOrDefault(a => a.Username == username).Id;
            inv.IssueDate = now;
            inv.Total = _context.Carts.Include(p => p.Product).Include(a => a.Account).Where(s => s.Account.Username == username).Sum(p => p.Quantity * p.Product.Price);
            _context.Add(inv);
            _context.SaveChanges();
            //Thêm chi tiết hóa đơn
            List<Cart> cart = _context.Carts.Include(p => p.Product).Include(a => a.Account).Where(m => m.Account.Username == username).ToList();
            foreach(Cart c in cart)
            {
                InvoiceDetail invD = new InvoiceDetail();
                invD.InvoiceId = inv.Id;
                invD.ProductId = c.ProductId;
                invD.Quantity = c.Quantity;
                invD.UnitPrice = c.Product.Price;
                _context.Add(invD);
            }
            _context.SaveChanges();
            //Trừ số lượng tồn kho
            foreach(Cart c in cart)
            {
                c.Product.Stock -= c.Quantity;
                _context.Remove(c);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private bool checkCart(string us)
        {
            List<Cart> cart = _context.Carts.Include(p => p.Product).Include(a => a.Account).Where(m => m.Account.Username == us).ToList();
            foreach(Cart c in cart)
            {
                if(c.Product.Stock < c.Quantity)
                {
                    return false;
                }
            }
            return true;
        }
        [HttpPost, ActionName("UpdateToCart")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateToCart(int id, int soluong)
        {
            var sp = await _context.Carts.FirstOrDefaultAsync(p => p.ProductId == id);
            if (soluong > 0)
            {
                sp.Quantity = soluong;
                _context.Update(sp);
            }
            else if (soluong < 0)
            {
                sp.Quantity = 1;
                _context.Update(sp);
            }
            else if (soluong == 0)
            {
                _context.Remove(sp);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
