using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2.Controllers
{
    public class App1Controller : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
    }
}
