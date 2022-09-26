using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Controllers
{
    public class EkartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
