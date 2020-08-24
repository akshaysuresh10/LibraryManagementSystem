using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Feedback
    {
        [Key]
        public int Fid { get; set; }
        public String Message { get; set; }
    }
}
