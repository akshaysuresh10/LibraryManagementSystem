using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(Student student)    
        {
            return RedirectToAction("Login");
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(String UserName, String Password)
        {
            if (UserName == "Akshay" && Password == "1234")
            {
                return RedirectToAction("HomePage");
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult HomePage()
        {
            return View();
        }


    }
}
