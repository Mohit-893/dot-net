using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData 
{
    public class Product : Interface.Ishowmenu
    {
        public int id { get; set; }
        public string name { get; set; }
        public int category_id { get; set; }
        public double price { get; set; }

        //public int loc { get; set; }
        
        public string category { get; set; }

        public void showmenu()
        {
            Console.Write("Press 1 for Insertion\n      2 for Deletion\n      3 for Updation\n      4 for Search Item\n      0 for exit\n");
        }
    }
}
