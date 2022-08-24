using System;
using System.Collections.Generic;
using System.Text;

namespace Studentdata
{
    public class Student
    {
        public int roll { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("Roll no. : " + roll + "\nName : " + name);
        }
    }
}
