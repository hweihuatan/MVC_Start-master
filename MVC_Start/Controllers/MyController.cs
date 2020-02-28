using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Edu()
        {
            Education eduInfo = new Education();
            eduInfo.University = "University of South Florida";
            eduInfo.StartYear = "2015";
            eduInfo.ExpectedGraduation = "2021";

            ViewData["Message"] = "My education page.";

            return View(eduInfo);
        }
    }
}