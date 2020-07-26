using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            return RedirectToAction("AdminLogin");
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Loginpage(String  Username,String Password)
        {
            if (Username == "Admin" && Password == "1234")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AdminLogin");
            }
            return View();
            
        }
        
    }
}
