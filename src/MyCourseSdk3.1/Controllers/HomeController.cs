using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourseSdk3._1.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
         return Content("Sono la index della home");   
        } 
    }
}