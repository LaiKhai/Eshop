using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eshop_Bookstore.Data;
using Eshop_Bookstore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Eshop_Bookstore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Eshop_BookstoreContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(Eshop_BookstoreContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchBy, string search, string filter)
        {
            //  Start: Kiểm tra user xem đã đăng nhập chưa
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                var userLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
                ViewBag.UserLogin = userLogin;
            }
            else
            {
                ViewBag.UserLogin = null;
            }
            //  End: Kiểm tra user xem đã đăng nhập chưa

            //  Start: Lấy DS Loại SP
            ViewBag.LstProductTypes = await _context.ProductTypes.ToListAsync();
            //  End: Lấy DS Loại SP

            //  Start: Tìm theo giá tiền
            if (filter != null)
            {
                int price = Convert.ToInt32(filter.Substring(4));
                var data = await _context.Products.Where(p => p.Price <= price).ToListAsync();
                return View(data);
            }
            //  End: Tìm theo giá tiền

            //  Start: Xử lý tìm kiếm
            if (searchBy != null && search != null)
            {
                if(searchBy == "Name")
                {
                    var data = await _context.Products.Where(p => p.Name.Contains(search)).ToListAsync();
                    return View(data);
                }
                else if(searchBy == "Description")
                {
                    var data = await _context.Products.Where(p => p.Decription.Contains(search)).ToListAsync();
                    return View(data);
                }               
                else if (searchBy == "ProductType")
                {
                    var data = await _context.Products.Where(p => p.ProductType.Name.Contains(search)).ToListAsync();
                    return View(data);
                }
            }
            //  End: Xử lý tìm kiếm
            
            var eshop_BookstoreContext = _context.Products.Include(p => p.ProductType);
            return View(await eshop_BookstoreContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //  Start: Kiểm tra user xem đã đăng nhập chưa
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                var userLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
                ViewBag.UserLogin = userLogin;
            }
            else
            {
                ViewBag.UserLogin = null;
            }
            //  End: Kiểm tra user xem đã đăng nhập chưa

            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SKU,Name,Actor,Decription,Price,Stock,ProductTypeId,Image,Status")] Product product, IFormFile Full_Image)
        {
            if (Full_Image.Length > 2000000)
            {
                ViewBag.SizeError = "Quá dung lượng cho phép !";
                return View();
            }
                if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                if (Full_Image.Length <= 2000000)
                {
                    var fileName = product.Id.ToString() + Path.GetExtension(Full_Image.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot", "EshopView", "assets", "img", "product");
                    var filePath = Path.Combine(uploadPath, fileName);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await Full_Image.CopyToAsync(stream);
                        stream.Flush();
                    }
                    product.Image = fileName;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", product.ProductTypeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SKU,Name,Actor,Decription,Price,Stock,ProductTypeId,Image,Status")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
