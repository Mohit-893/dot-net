using System;
using System.Collections.Generic;
using System.Text;

namespace BookingRecord
{
    public class Booking : Commondata.Commonfield, Interface.Ienterdata, Interface.Idisplaydata
    {
        string dept;
        int bedtime;
        public void display()
        {
            Console.WriteLine("ID : " + id + "\tName : " + name + "\tDepartment : " + dept);
            Console.WriteLine("Address : " + address + "\tPhone no. : " + phone + "\tBedTime : " + bedtime);
            Console.WriteLine("Price : " + (bedtime*1200));
        }

        public void enter()
        {
            Console.Write("Enter ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Department : ");
            dept = Console.ReadLine();
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Phone no. : ");
            phone = double.Parse(Console.ReadLine());
            Console.Write("Enter Bed Time(in days) : ");
            bedtime = int.Parse(Console.ReadLine());
        }
    }
}
