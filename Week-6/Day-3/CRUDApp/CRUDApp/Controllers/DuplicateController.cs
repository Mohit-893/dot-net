using CRUDApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Controllers
{
    public class DuplicateController : Controller
    {
            private readonly StudentContext _context;

            public DuplicateController(StudentContext context)
            {
                _context = context;
            }


            public IActionResult Index()
            {
                var stu = _context.Students.ToList();
                return View(stu);
            }
            public IActionResult Details(int id)
            {
                var stu = _context.Students.Find(id);
                return View(stu);
            }

            public IActionResult Create()
            {

                return View();
            }

            [HttpPost]
            public IActionResult Create(Student student)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            public IActionResult DeleteStudent(int id)
            {
                var student = _context.Students.Find(id);
                _context.Students.Remove(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            public IActionResult Delete(int id)
            {
                var stu = _context.Students.Find(id);
                return View(stu);
            }

            public IActionResult Edit(int id)
            {
                var student = _context.Students.Find(id);

                return View(student);
            }

            public IActionResult EditStudents(Student student)
            {
                _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
    }
}
