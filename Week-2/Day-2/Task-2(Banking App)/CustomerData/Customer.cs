using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class Customer : Interface.Ishowcustomermenu
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string acc_no { get; set; }
        public double phone { get; set; }

        public void showmenu()
        {
            Console.WriteLine("Press 1 for Adding New Customer Record");
            Console.WriteLine("Press 2 for Update Customer Record");
            Console.WriteLine("Press 3 for Delete Customer Record");
        }
    }
}
