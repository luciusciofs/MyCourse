using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace MyCourseSdk3._1.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
         return Content("Sono la index di coursecontroller");   
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono detail di coursecontroller, ho ricevuto l'id {id}");
        }
    }
}