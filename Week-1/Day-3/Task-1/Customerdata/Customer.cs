using System;
using System.Collections.Generic;
using System.Text;

namespace Customerdata
{
    public class Customer :Commonfield.Classid, Interface.Idisplay,Interface.Ienterdata

    {
        string name;
        string add;
        double phone;
        Commonfield.Classid cid = new Commonfield.Classid();
        public void display()
        {
            Console.WriteLine("Customer details are : " + cid.id + " " + name + " " + add + " " + phone);
        }

        public void enterdata()
        {
            Console.Write("Enter Customer Id : ");
            cid.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Customer Address : ");
            add = Console.ReadLine();
            Console.Write("Enter Customer Phone Number : ");
            phone = double.Parse(Console.ReadLine());
        }

    }
}
