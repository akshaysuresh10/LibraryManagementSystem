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
        private readonly AppDbContext _context;
        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student Student)
        {
            //ToDb
            //Creating an object of AppDbcontext
            //AppDbContext Context=New AppDbContext() 
            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }

    //    [HttpPost]
      //  public IActionResult SignIn(Student student)    
        //{
        //  return RedirectToAction("Login");
        //}
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(String UserName, String Password)
        {
            var StudentList = _context.Students.ToList();

            var SelectedStudent = StudentList.Where(x => x.Email == UserName && x.Password == Password).FirstOrDefault();
            if (SelectedStudent==null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return RedirectToAction("HomePage");
            }
            return View();
        }

        public IActionResult HomePage()
        {
            return View();
        }


    }
}
