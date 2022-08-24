using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class student
    {
        public int roll { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("Roll No. " + roll + "Name :" + name);
        }
    }
}
