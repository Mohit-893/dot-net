using System;
using System.Collections.Generic;
using System.Text;

namespace Productdata
{
    public class Product : Commonfield.Classid, Interface.Idisplay, Interface.Ienterdata
    {
        Commonfield.Classid cid = new Commonfield.Classid();
        string name;
        string category;
        double price;
        public void display()
        {
            Console.WriteLine("Product details are : " + cid.id + " " + name + " " + category + " " + price);
        }

        public void enterdata()
        {
            Console.Write("Enter Product ID : ");
            cid.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Product Category : ");
            category = Console.ReadLine();
            Console.Write("Enter Product Price : ");
            price = double.Parse(Console.ReadLine());
        }
    }
}
