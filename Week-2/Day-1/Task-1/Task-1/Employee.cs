using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        private double salary { get; set; }
        protected string email { get; set; }



        //public property to access private data members
        public double getsalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
}
