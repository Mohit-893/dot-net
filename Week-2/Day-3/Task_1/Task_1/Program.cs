using System;
using System.Data.SqlClient;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=localhost;database=school;integrated security=true;");
            StudentData.Student st = new StudentData.Student();
            Console.Write("Enter name : ");
            st.name = Console.ReadLine();
            Console.Write("Enter Class : ");
            st.clas = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into student values('"+st.name+"','"+st.clas+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Student data added");
        }
    }
}
