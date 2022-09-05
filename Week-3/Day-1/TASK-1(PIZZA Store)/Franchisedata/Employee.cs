using System;
using System.Collections.Generic;
using System.Text;

namespace Franchisedata
{
    public class Employee : Interface.Ishowmenu
    {
        public int id { get; set; }
        public string e_name { get; set; }
        public string e_dept { get; set; }
        public double e_sal { get; set; }
        public string e_doj { get; set; }
        public string f_name { get; set; }

        public void showmenu()
        {
            Console.WriteLine("Press 1 for Add Employee\n      2 for Order\n      3 for Salary Distribution\n      4 for Sales Record\n      0 for exit");
        }
    }
}
