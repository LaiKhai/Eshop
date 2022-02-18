using Eshop_Bookstore.Data;
using Eshop_Bookstore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Controllers
{
    public class LoginController : Controller
    {
        public readonly Eshop_BookstoreContext _context;

        public LoginController(Eshop_BookstoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.reFail = HttpContext.Session.GetInt32("reFail");
            //return RedirectToAction("Index", "Login");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Account user)
        {
            var userLogin =  await _context.Accounts.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
            ViewBag.UserLogin = userLogin;
            if (userLogin != null)
            {
                ViewBag.r = true;
                Account us = _context.Accounts.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
                if (userLogin.IsAdmin)
                {
                    HttpContext.Session.SetString("username", user.Username);
                    HttpContext.Session.SetString("password", user.Password);
                    HttpContext.Session.SetInt32("UserID", us.Id);
                    return RedirectToAction("Home", "Admin");
                }
                else
                {
                    HttpContext.Session.SetString("username", user.Username);
                    HttpContext.Session.SetString("password", user.Password);
                    HttpContext.Session.SetInt32("UserID", us.Id);
                    return RedirectToAction("Index","Home");
                }
            }
            else
            {
                ViewBag.r = false;
                //return Ok("Sai username hoặc password");
                return View("Index");
            }
        }

    }
}
