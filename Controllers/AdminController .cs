using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Loginpage(String Username, String Password)
        {
            if (Username == "Admin" && Password == "1234")
            {
                return RedirectToAction("AdminHome");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
            

        }
        public IActionResult AdminHome()
        {
            return View();
        }
        
        public IActionResult Book()
        {
            return RedirectToAction("AddBook");
        }
        
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookAdded(Book book)
        {
            return View();
        }
    }
}
