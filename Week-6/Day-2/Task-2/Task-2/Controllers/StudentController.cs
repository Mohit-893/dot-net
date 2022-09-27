using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentViewModel stu = new StudentViewModel()
            {
                Name = "Mohit",
                RollNo = 17,
                ClassSection = "VII C"
            };

            AddressViewModel add = new AddressViewModel()
            {
                City = "Greater Noida",
                State = "UP",
                Street = "Palm Garden Street",
                Pincode = 201305
            };

            StudentAddressViewModel stdadd = new StudentAddressViewModel()
            {
                StudentData = stu,
                Address = add
            };
            return View(stdadd);
        }
    }
}
