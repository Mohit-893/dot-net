using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string ClassSection { get; set; }
        public Student GetStudentbyId()
        {
            return new Student { StudentId = 13, Name = "Mohit", RollNo = 17, ClassSection = "VII A" };
        }
    }
}
