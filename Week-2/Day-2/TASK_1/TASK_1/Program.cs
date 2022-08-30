﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace TASK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();


            //Connection strings
            SqlConnection con = new SqlConnection("server=localhost;database=Employee;integrated security=true;");

            
            Console.Write("Press 1 for insert\n      2 for Delete\n      3 for Update\n      4 for Search");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter name of employee : ");
                    emp.name = Console.ReadLine();
                    Console.Write("Enter department of employee : ");
                    emp.department = Console.ReadLine();
                    Console.Write("Enter salary of employee : ");
                    emp.salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter gender of employee : ");
                    emp.gender = Console.ReadLine();
                    SqlCommand cmd = new SqlCommand("insert into Employee values(' " + emp.name + " ',' " + emp.department + " ',' " + emp.salary + " ',' " + emp.gender + " ')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record inserted successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter id of employee");
                    emp.id = int.Parse(Console.ReadLine());
                    SqlCommand cmd1 = new SqlCommand("delete from Employee where id=" + emp.id +" ", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record deleted successfully");
                    break;
                case 3:
                    Console.WriteLine("Enter id of employee to be updated");
                    emp.id = int.Parse(Console.ReadLine());

                    Console.Write("Enter name of employee : ");
                    emp.name = Console.ReadLine();
                    Console.Write("Enter department of employee : ");
                    emp.department = Console.ReadLine();
                    Console.Write("Enter salary of employee : ");
                    emp.salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter gender of employee : ");
                    emp.gender = Console.ReadLine();

                    SqlCommand cmd2 = new SqlCommand("update Employee set name='"+emp.name+"' ,dept='"+emp.department+"' ,salary="+emp.salary+" ,gender='"+emp.gender+"' where id="+emp.id+"",con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record Updated successfully");
                    break;
                case 4:
                    Console.WriteLine("Enter id of employee to be Searched");
                    emp.id = int.Parse(Console.ReadLine());
                    SqlDataAdapter da = new SqlDataAdapter("select * from Employee", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds,"Employee");

                    int x = ds.Tables[0].Rows.Count;
                    for (int i = 0; i < x; i++)
                    {
                        if (emp.id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                        {
                            Console.WriteLine("Name : " + ds.Tables[0].Rows[i][1].ToString());
                            Console.WriteLine("Department : " + ds.Tables[0].Rows[i][2].ToString());
                            Console.WriteLine("Salary : " + ds.Tables[0].Rows[i][3].ToString());
                            Console.WriteLine("Gender : " + ds.Tables[0].Rows[i][4].ToString());
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Input !!!");
                    break;
            }
        }
    }
}
