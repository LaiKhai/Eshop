using Eshop_Bookstore.Areas.API.Controllers;
using Eshop_Bookstore.Data;
using Eshop_Bookstore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly Eshop_BookstoreContext _context;

        public HomeController(ILogger<HomeController> logger, Eshop_BookstoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
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

            ViewBag.lstProducts = await _context.Products.ToListAsync();
            ViewBag.updateInfo = HttpContext.Session.GetInt32("updateInfo");
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Account user)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44347/api/token", content))
                {
                    if(response.ReasonPhrase == "OK")
                    {
                        //  get user để kiểm tra đăng nhập
                        ViewBag.UserLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
                        
                        //  Get token
                        ViewBag.Token = HttpContext.Session.GetString("JWTToken");
                        //var a = HttpContext.Session.GetString("JWTToken");

                        string token = await response.Content.ReadAsStringAsync();
                        HttpContext.Session.SetString("JWTToken", token); 
                    }
                }
            }

            var userLogin = ViewBag.UserLogin;
            if(userLogin != null)
            {
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
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Register()
        {
            ViewBag.reFail = HttpContext.Session.GetInt32("reFail");
            return View("Register");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Account _user)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // clear token

            return RedirectToAction("Index","Login");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
