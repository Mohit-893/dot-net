using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2.Controllers
{
    public class App2Controller : Controller
    {
        public IActionResult Contactus()
        {
            return View();
        }
        public IActionResult Comment()
        {
            return View();
        }
    }
}
