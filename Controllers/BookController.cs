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

        public IActionResult ViewBook()
        {
            try
            {
                var BooksList = _context.Books.ToList();

                return View(BooksList);

            }
            catch (Exception ex)
            {


            }
            return View();
        }


        [HttpPost]
        public IActionResult EditBook(Book bookfromEditform)
        {
            try
            {
                var selectedBook = _context.Books.ToList().Where(x => x.BookId == bookfromEditform.BookId).FirstOrDefault();

                selectedBook.BookName = bookfromEditform.BookName;
                selectedBook.Author = bookfromEditform.Author;
                selectedBook.Prize = bookfromEditform.Prize;
                selectedBook.Category = bookfromEditform.Category;
                selectedBook.Image = bookfromEditform.Image;
                _context.Books.Update(selectedBook);
                _context.SaveChanges();



            }
            catch (Exception ex)
            {


            }
            return RedirectToAction("ViewBook");
        }



    }
}
