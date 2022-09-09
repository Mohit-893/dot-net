using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string department;
            double salary;

            Console.Write("Enter name : ");
            name = Console.ReadLine();
            Console.Write("\nEnter Department : ");
            department = Console.ReadLine();
            Console.Write("\nEnter salary : ");
            salary = double.Parse(Console.ReadLine());


            SqlConnection con = new SqlConnection("server=localhost;database=Employee;integrated security=true;");
            string str = "insert into Employee_data values('" + name + "','" + department + "'," + salary + ")";
            SqlCommand cmd1 = new SqlCommand(str, con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();

            string str1 = $"{name} || {department} || {salary}"; 
            using (TextWriter writer = File.AppendText("C:\\Users\\mohit\\OneDrive - Bhavna Software India Pvt.Ltd\\Desktop\\.net_traning\\dot net\\Week-3\\Day-5\\Task-1\\textdata.txt"))
            {
                writer.WriteLine(str1);
            }
        }
    }
}
