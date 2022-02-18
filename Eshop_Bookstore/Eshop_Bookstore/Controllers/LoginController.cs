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
            //return RedirectToAction("Index", "Login");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Account user)
        {
            //using (var httpClient = new HttpClient())
            //{
            //    StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            //    using (var response = await httpClient.PostAsync("https://localhost:44347/api/token", content))
            //    {
            //        if (response.ReasonPhrase == "OK")
            //        {
            //            //  get user để kiểm tra đăng nhập
            //            ViewBag.UserLogin = await _context.Accounts.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);

            //            //  Get token
            //            ViewBag.Token = HttpContext.Session.GetString("JWTToken");
            //            //var a = HttpContext.Session.GetString("JWTToken");

            //            string token = await response.Content.ReadAsStringAsync();
            //            HttpContext.Session.SetString("JWTToken", token);
            //        }
            //    }
            //}
            var userLogin =  await _context.Accounts.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
            ViewBag.UserLogin = userLogin;
            if (userLogin != null)
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
                    return RedirectToAction("Index","Home");
                }
            }
            else
            {
                return Ok("Sai username hoặc password");
            }
        }

    }
}
