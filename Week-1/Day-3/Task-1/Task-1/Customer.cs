using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Customer :Classid, Idisplay, Ienterdata
    {
        string name;
        string add;
        double phone;
        public void display()
        {
            Console.WriteLine("Customer details are : "+id+" "+name+" "+add+" "+phone);
        }

        public void enterdata()
        {
            Console.Write("Enter Customer Id : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Customer Address : ");
            add = Console.ReadLine();
            Console.Write("Enter Customer Phone Number : ");
            phone = double.Parse(Console.ReadLine());
        }
    }
}
