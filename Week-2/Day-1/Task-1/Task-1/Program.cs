using System;

namespace Task_1
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            fc.show();
            SecondClass sc = new SecondClass();
            sc.show();
            Employee obj = new Employee();
	    obj.name = "Mohit";
            obj.getsalary = 20;
            Console.WriteLine(obj.getsalary);

            Program o = new Program(); // to access protected properties
            o.email = "abcd@gmail.com";
        }
    }
}
