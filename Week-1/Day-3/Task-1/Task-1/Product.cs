using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Product :Classid, Idisplay, Ienterdata
    {
        string name;
        string category;
        double price;
        public void display()
        {
            Console.WriteLine("Product details are : " + id + " " + name + " " + category + " " + price);
        }

        public void enterdata()
        {
            Console.Write("Enter Product ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Product Category : ");
            category = Console.ReadLine();
            Console.Write("Enter Product Price : ");
            price = double.Parse(Console.ReadLine());
        }
    }
}
