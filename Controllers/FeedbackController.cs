using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Feedback()
        {
            return View();
        }

        public IActionResult FeedView(Feedback Feedback)
        {
            return RedirectToAction("FeedView");
        }


    }
}
