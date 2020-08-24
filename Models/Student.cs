using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}
