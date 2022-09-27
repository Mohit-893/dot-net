using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student stu = new Student();
            Student abc = stu.GetStudentbyId();
            return View(abc);
        }
    }
}
