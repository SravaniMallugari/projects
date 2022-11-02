using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loginpage.Models;

namespace Loginpage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1,username="sravs",password="sravs@123"},
                new UserModel{id=2,username="sravani",password="sravani@123"},

            };

            return users;
        }

        [HttpPost]
        public IActionResult Verify(UserModel usr)
        {
            var u = PutValue();

            var ue = u.Where(u => u.username.Equals(usr.username));

            var up = ue.Where(p => p.password.Equals(usr.password));

            if (up.Count() == 1)
            {
                ViewBag.message = "your login is successfull";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "incorrect username or password ";
                return View("Login");
            }
        }
    }
}
