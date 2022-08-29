using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorRecord
{
    public class Doctor : Commondata.Commonfield, Interface.Ienterdata, Interface.Idisplaydata
    {
        string department;
        double salary;
        //Commondata.Commonfield cd = new Commondata.Commonfield();

        public void display()
        {
            Console.WriteLine("ID : "+id+"\tName : "+name+"\tDepartment : "+department);
            Console.WriteLine("Address : "+address+"\tPhone no. : "+phone+"\tSalary : "+salary);
        }

        public void enter()
        {
            Console.Write("Enter ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Department : ");
            department = Console.ReadLine();
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Phone no. : ");
            phone = double.Parse(Console.ReadLine());
            Console.Write("Enter Salary : ");
            salary = double.Parse(Console.ReadLine());
        }
    }
}
