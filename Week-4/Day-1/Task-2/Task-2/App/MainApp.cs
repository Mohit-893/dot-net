using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Task_2.Domain.Entities;
using Task_2.Domain.Enums;
using Task_2.Domain.Interfaces;
using Task_2.UI;

namespace Task_2.App
{
    public class MainApp : Imenus,Ivalidate
    {

        private admin curradmin;
        private Employee curremployee;
        private int todaySaleQuantity;
        private double todaySaleAmount;
        private int thisMonthSaleQuantity;
        private double thisMonthSaleAmount;

        SqlConnection con = new SqlConnection("server=localhost;database=CarApp;integrated security=true;");

        public static void firstMethod()
        {
            Console.WriteLine("Welcome to Car App");
            Methods.showMainMenu();
            ProcessMenuOption();
        }

        private static void ProcessMenuOption()
        {
            var mapp = new MainApp();
            switch (Validate.Convert<int>("an option"))
            {
                case (int)MainMenu.Admin:
                    Methods.GetAdminData();
                    mapp.AdminData();
                    break;
                case (int)MainMenu.Employee:
                    //Methods.GetEmployeeData();
                    Methods.showEmployeeMenu();
                    mapp.EmployeeData();
                    break;
                case (int)MainMenu.Customer:
                    GetCustomerData();
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        private static void GetCustomerData()
        {
            var mapp = new MainApp();
            string name = Validate.Convert<string>(" your Name");
            Methods.showWelcomeScreen(name);
            Methods.showCarMenu();
            (double price,string Carname) = mapp.CustomerData();
            Console.Clear();
            Methods.PrintMessage($"Total amount is : {price}");
            SqlCommand cmd1 = new SqlCommand("insert into Sales values('" + name + "','" + Carname + "',"+price+",CAST(GETDATE() as date))", mapp.con);
            mapp.con.Open();
            cmd1.ExecuteNonQuery();
            mapp.con.Close();
        }

        public void AdminData()
        {
            switch (Validate.Convert<int>("an option"))
            {
                case (int)AdminMenu.AddEmployee:
                    AddEmployee();
                    break;
                case (int)AdminMenu.TotalProfit:
                    TotalProfit();
                    break;
                case (int)AdminMenu.TotalSales:
                    TotalSales();
                    break;
                case (int)AdminMenu.BalanceSheet:
                    BalanceSheet();
                    break;
                case (int)AdminMenu.UpdateQuantity:
                    UpdateQuantity();
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        private void UpdateQuantity()
        {
            Methods.PrintMessage("Product quantity is updated");
        }

        private void BalanceSheet()
        {
            Methods.PrintMessage("In this option you were able to see the whole data of the CarApp");
        }

        private void TotalSales()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select sum(price) as totalsales,count(Carname) as quantity from Sales where OrderDate = CAST(GETDATE() as date)", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            todaySaleQuantity = int.Parse(ds1.Tables[0].Rows[0][1].ToString());
            todaySaleAmount = double.Parse(ds1.Tables[0].Rows[0][0].ToString());
            //int x = ds1.Tables[0].Rows.Count;
            //Console.WriteLine(todaySale);
            SqlDataAdapter da2 = new SqlDataAdapter("select sum(price) as totalsales,count(Carname) as quantity from Sales where OrderDate > DATEFROMPARTS(year(Orderdate),month(Orderdate),'01')", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            thisMonthSaleQuantity = int.Parse(ds2.Tables[0].Rows[0][1].ToString());
            thisMonthSaleAmount = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
            Methods.PrintMessage($"Today's sale quantity is {todaySaleQuantity}.Today's Sale amount is {todaySaleAmount}");
            Methods.PrintMessage($"This Month sale quantity is {thisMonthSaleQuantity}.This Month Sale amount is {thisMonthSaleAmount}");
        }

        private void TotalProfit()
        {
            double todayProfit = 0, totalProfit = 0;
            Methods.PrintMessage($"Profit for today is : {todayProfit}\nProfit for the Month is : {totalProfit}");
        }

        private void AddEmployee()
        {
            Employee emp = new Employee();
            emp.e_name = Validate.Convert<string>("Employee Name ");
            emp.salary = Validate.Convert<int>("Employee Salary ");
            emp.e_department = Validate.Convert<string>("Employee Department ");
            SqlCommand cmd1 = new SqlCommand("insert into Employee values('" + emp.e_name + "'," + emp.salary + ",'"+emp.e_department+"')", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Methods.PrintMessage("Employee added successfully");
        }

        public void EmployeeData()
        {
            switch (Validate.Convert<int>("an option"))
            {
                case (int)EmployeeMenu.Login:
                    EmployeeLogin();
                    break;
                case (int)EmployeeMenu.Salary:
                    Methods.PrintMessage($"Salary of name for this month is salary");
                    break;
                case (int)EmployeeMenu.Logout:
                    EmployeeLogout();
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        private void EmployeeLogout()
        {
            int id = Validate.Convert<int>("Employee id");
            string name = Validate.Convert<string>("Employee Name");
            SqlDataAdapter da1 = new SqlDataAdapter("select * from EmployeeData where id=" + id + "and name='" + name + "'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            int x = ds1.Tables[0].Rows.Count;
            if (x > 0)
            {
                SqlCommand cmd1 = new SqlCommand("insert into EmployeeLogout values(" + id + ",'" + name + "',GETDATE())", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Methods.PrintMessage("Employee Logout Successful...");
            }
            else
                Methods.PrintMessage("No Employee Found!!!", false);
        }

        private void EmployeeLogin()
        {
            int id = Validate.Convert<int>("Employee id");
            string name = Validate.Convert<string>("Employee Name");
            SqlDataAdapter da1 = new SqlDataAdapter("select * from EmployeeData where id="+id+ "and name='"+name+"'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            int x = ds1.Tables[0].Rows.Count;
            if (x > 0)
            {
                SqlCommand cmd1 = new SqlCommand("insert into EmployeeLogin values(" + id + ",'" + name + "',GETDATE())", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Methods.PrintMessage("Employee Login Successful...");
            }
            else
                Methods.PrintMessage("No Employee Found!!!", false);
        }

        public (double,string) CustomerData()
        {
            switch(Validate.Convert<int>("an option"))
            {
                case (int)CarMenu.Hatchback:
                    return (745000,"Hatchback");
                    break;
                case (int)CarMenu.Sedan:
                    return (990000,"Sedan");
                    break;
                case (int)CarMenu.MiniSUV:
                    return (1235000,"MiniSUV");
                    break;
                case (int)CarMenu.SUV:
                    return (1600000,"SUV");
                    break;
                default:
                    return (0," ");
                    break;
            }
        }

        public void ValidateEmployee(string name, string pass)
        {
            if (name == "emp" && pass == "1234")
                Methods.showEmployeeMenu();
            else
                Methods.PrintMessage("Invalid Employee...", false);
        }

        public void ValidateAdmin(string name,string pass)
        {
            if (name == "mohit" && pass == "1234")
                Methods.showAdminMenu();
            else
                Methods.PrintMessage("Invalid Admin...", false);
        }
    }
}
