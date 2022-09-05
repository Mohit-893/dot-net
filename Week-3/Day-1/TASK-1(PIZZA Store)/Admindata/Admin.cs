using System;
using System.Collections.Generic;
using System.Text;

namespace Admindata
{
    public class Admin : Interface.Ishowmenu
    {
        public int id { get; set; }
        public string f_name { get; set; }
        public string pass { get; set; }

        public void showmenu()
        {
            Console.WriteLine("Press 1 for Add Franchise\n      2 for Franchise record\n      3 for sales record\n      0 for exit");
        }
    }
}
