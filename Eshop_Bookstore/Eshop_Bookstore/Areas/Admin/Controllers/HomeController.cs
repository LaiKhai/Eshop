using Eshop_Bookstore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public readonly Eshop_BookstoreContext _context;

        public HomeController( Eshop_BookstoreContext context)
        {
            _context = context;
        }

        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            
            var username = HttpContext.Session.GetString("username");
            var password = HttpContext.Session.GetString("password");
            if (username != null)
            {
                var userLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
                ViewBag.UserLogin = userLogin;
                ViewBag.r = true;
            }
            else
            {
                ViewBag.UserLogin = null;
            }
            return View();
        }
    }
}
