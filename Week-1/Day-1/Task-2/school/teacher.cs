using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class teacher
    {
        public int ID { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("ID : " + ID + "\nName :" + name);
        }
    }
}
