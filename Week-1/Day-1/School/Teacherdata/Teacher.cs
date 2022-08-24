using System;
using System.Collections.Generic;
using System.Text;

namespace Teacherdata
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("ID : " + id + "\nName : " + name);
        }
    }
}
