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
        public readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddBook(Book Book)
        {
            _context.Books.Add(Book);
            _context.SaveChanges();
            return RedirectToAction("Page2");
        }

        public IActionResult Page2()
        {
            return View();
        }







    }
}
