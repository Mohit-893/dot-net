using System;
using System.Collections.Generic;
using System.Text;

namespace PatientRecord
{
    public class Patient : Commondata.Commonfield, Interface.Ienterdata, Interface.Idisplaydata
    {
        string preferdoctor;
        double amount;
        public void display()
        {
            Console.WriteLine("ID : " + id + "\tName : " + name + "\tDoctor : " + preferdoctor);
            Console.WriteLine("Address : " + address + "\tPhone no. : " + phone + "\tTotal amount : " + amount);
        }

        public void enter()
        {
            Console.Write("Enter ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Doctor Name : ");
            preferdoctor = Console.ReadLine();
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Phone no. : ");
            phone = double.Parse(Console.ReadLine());
            Console.Write("Enter Total amount : ");
            amount = double.Parse(Console.ReadLine());
        }
    }
}
