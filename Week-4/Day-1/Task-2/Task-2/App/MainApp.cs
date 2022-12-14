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
    public class MainApp : Imenus
    {
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
                    Employee();
                    break;
                case (int)MainMenu.Customer:
                    GetCustomerData();
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        private static void Employee()
        {
            var mapp = new MainApp();
            //Methods.GetEmployeeData();
            (bool isvalid, int id, string name) = mapp.ValidateEmployee();
            if (isvalid)
            {
                //Console.WriteLine(mapp.curremployee.e_department);
                Methods.showEmployeeMenu(name);
                mapp.EmployeeData(id, name);
            }
            else
            {
                Methods.PrintMessage("No Employee Found!!!", false);
            }


        }

        private (bool,int,string) ValidateEmployee()
        {
            int id = Validate.Convert<int>("Employee id");
            string name = Validate.Convert<string>("Employee Name");
            SqlDataAdapter da1 = new SqlDataAdapter("select * from EmployeeData where id=" + id + "and name='" + name + "'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            int x = ds1.Tables[0].Rows.Count;
            if (x > 0)
            {
                Console.WriteLine(ds1.Tables[0].Rows.Count);
                /*
                foreach (DataRow dataRow in ds1.Tables[0].Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.WriteLine(item);
                    }
                }
                */
                return (true,id,name);
            }
            return (false,0," ");
        }

        private static void GetCustomerData()
        {
            var mapp = new MainApp();
            string name = Validate.Convert<string>(" your Name");
            Methods.showWelcomeScreen(name);
            Methods.showCarMenu();
            (double price,string Carname) = mapp.CustomerData();
            Console.Write("Please wait your Product is Under Process.");
            Methods.Animation();

            Predicate<string> obj3 = new Predicate<string>(checkStock);
            bool status = obj3.Invoke(name);
            if(status)
            {
                Console.Clear();
                Methods.PrintMessage($"Total amount is : {price}");
                SqlCommand cmd1 = new SqlCommand("insert into Sales values('" + name + "','" + Carname + "'," + price + ",CAST(GETDATE() as date))", mapp.con);
                mapp.con.Open();
                cmd1.ExecuteNonQuery();
                mapp.con.Close();
            }
            else
            {
                Console.Clear();
                Methods.PrintMessage("Product Quantity is not Sufficient...");
            }
           
        }

        private static bool checkStock(string name)
        {
            MainApp mapp = new MainApp();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from InitialStock", mapp.con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            int bodyQuan = int.Parse(ds1.Tables[0].Rows[0][2].ToString());
            int engineQuan = int.Parse(ds1.Tables[0].Rows[1][2].ToString());
            int seatQuan = int.Parse(ds1.Tables[0].Rows[2][2].ToString());
            int doorQuan = int.Parse(ds1.Tables[0].Rows[3][2].ToString());
            int mirrorQuan = int.Parse(ds1.Tables[0].Rows[4][2].ToString());
            if((bodyQuan >=1) && (engineQuan >=1) && (seatQuan >=4) && (doorQuan>=5) && (mirrorQuan >= 5))
            {
                SqlCommand cmd1 = new SqlCommand("update InitialStock set Quantity=Quantity-1 where id=1 or id=2", mapp.con);
                SqlCommand cmd2 = new SqlCommand("update InitialStock set Quantity = Quantity - 5 where id = 4 or id = 5", mapp.con);
                SqlCommand cmd3 = new SqlCommand("update InitialStock set Quantity = Quantity - 4 where id = 3, con)", mapp.con);
                mapp.con.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                mapp.con.Close();
                return true;
            }
            else
            {
                return false;
            }

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
            int id = Validate.Convert<int>(" stock id");
            int quantity = Validate.Convert<int>("New Quantity");
            SqlCommand cmd2 = new SqlCommand("update InitialStock set Quantity="+quantity+" where id="+id, con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void BalanceSheet()
        {
            Methods.PrintMessage("In this option you were able to see the whole data of the CarApp");
        }

        private void TotalSales()
        {
            calculateSales();
            //int x = ds1.Tables[0].Rows.Count;
            //Console.WriteLine(todaySale)
            Methods.PrintMessage($"Today's sale quantity is {todaySaleQuantity}.Today's Sale amount is {todaySaleAmount}");
            Methods.PrintMessage($"This Month sale quantity is {thisMonthSaleQuantity}.This Month Sale amount is {thisMonthSaleAmount}");
        }

        private void calculateSales()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select sum(price) as totalsales,count(Carname) as quantity from Sales where OrderDate = CAST(GETDATE() as date)", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            todaySaleQuantity = int.Parse(ds1.Tables[0].Rows[0][1].ToString());
            //todaySaleAmount = double.Parse(ds1.Tables[0].Rows[0][0].ToString());
            if (ds1.Tables[0].Rows[0][0].ToString() == null)
                todaySaleAmount = 0;
            else
                todaySaleAmount = double.Parse(ds1.Tables[0].Rows[0][0].ToString());

            SqlDataAdapter da2 = new SqlDataAdapter("select sum(price) as totalsales,count(Carname) as quantity from Sales where OrderDate > DATEFROMPARTS(year(Orderdate),month(Orderdate),'01')", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            thisMonthSaleQuantity = int.Parse(ds2.Tables[0].Rows[0][1].ToString());
            //ds2.Tables[0].Rows[0][0].ToString() != NULL ? thisMonthSaleAmount = double.Parse(ds2.Tables[0].Rows[0][0].ToString()) : thisMonthSaleAmount=0;
            if (ds2.Tables[0].Rows[0][0].ToString() == null)
                thisMonthSaleAmount = 0;
            else
                thisMonthSaleAmount = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
        }

        private void TotalProfit()
        {
            calculateSales();
            double todayProfit = (todaySaleAmount*0.35)-(todaySaleQuantity*4520), totalProfit = (thisMonthSaleAmount*0.35)-(thisMonthSaleQuantity*113000);
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

        public void EmployeeData(int id, string name)
        {
            switch (Validate.Convert<int>("an option"))
            {
                case (int)EmployeeMenu.Login:
                    EmployeeLogin(id,name);
                    break;
                case (int)EmployeeMenu.Salary:
                    CalculateSalary(id, name);
                    break;
                case (int)EmployeeMenu.Logout:
                    EmployeeLogout(id,name);
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        private void CalculateSalary(int id, string name)
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select sum(convert(int,EmployeeWorkingHours.workinghours)) from EmployeeWorkingHours where Emp_ID="+id, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            int totalhours = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
            double Salary = totalhours*80;
            Methods.PrintMessage($"Your Salary till yet is : {Salary}");
        }

        private void EmployeeLogout(int id,string name)
        {
                SqlCommand cmd1 = new SqlCommand("insert into EmployeeLogout values(" + id + ",'" + name + "',GETDATE())", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
            Methods.PrintMessage("Employee Logout Successful...");
        }

        private void EmployeeLogin(int id,string name)
        {
                SqlCommand cmd1 = new SqlCommand("insert into EmployeeLogin values(" + id + ",'" + name + "',GETDATE())", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Methods.PrintMessage("Employee Login Successful...");
               
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


        public void ValidateAdmin(string name,string pass)
        {
            if (name == "mohit" && pass == "1234")
                Methods.showAdminMenu();
            else
                Methods.PrintMessage("Invalid Admin...", false);
        }
    }
}
