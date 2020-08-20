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
        public AccountController (AppDbContext context)
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
            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(String UserName, String Password)
        {
            //get all students details from db
           var studentsList= _context.Students.ToList();
            var selectedStudent = studentsList.Where(x => x.Email.ToLower() == UserName.ToLower() && 
            x.Password== Password).FirstOrDefault();

            if(selectedStudent==null)
            {
                return RedirectToAction("failed");
            }
            else
            {
                return RedirectToAction("Index", "Homenew");
            }

            

            
            return View();
        }
        public IActionResult failed()
        {
            return View();
        }

        public IActionResult HomePage()
        {
            return View();
        }


    }
}
