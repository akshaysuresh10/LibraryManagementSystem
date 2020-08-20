using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index2()
        {
            try
            {
                var StudentsList = _context.Students.ToList();

                return View(StudentsList);

            }
            catch (Exception ex)
            {

               
            }
            return View();
        }
    }
}
