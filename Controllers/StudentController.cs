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


        [HttpPost]
        public IActionResult EditStudent(Student studentfromEditform)
        {
            try
            {
                var selectedStudent = _context.Students.ToList().Where(x=>x.Id==studentfromEditform.Id).FirstOrDefault();

                selectedStudent.FirstName = studentfromEditform.FirstName;
                selectedStudent.LastName = studentfromEditform.LastName;
                selectedStudent.RollNo = studentfromEditform.RollNo;
                selectedStudent.Department = studentfromEditform.Department;

                _context.Students.Update(selectedStudent);
                _context.SaveChanges();



            }
            catch (Exception ex)
            {

                
            }
            return RedirectToAction("Index2");
        }
        
    }
}
