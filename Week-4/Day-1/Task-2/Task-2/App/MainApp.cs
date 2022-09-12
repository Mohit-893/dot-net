using System;
using System.Collections.Generic;
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
                    Methods.GetEmployeeData();
                    mapp.EmployeeData();
                    break;
                case (int)MainMenu.Customer:
                    Methods.GetDesignData();
                    mapp.DesignData();
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

       
       public void AdminData()
        {
            switch (Validate.Convert<int>("an option"))
            {
                case (int)AdminMenu.AddEmployee:
                    Methods.PrintMessage("Employee added successfully");
                    break;
                case (int)AdminMenu.TotalProfit:
                    Methods.PrintMessage("Totalprofit for today is profit");
                    break;
                case (int)AdminMenu.TotalSales:
                    Methods.PrintMessage("Total sale quantity is quantity\nThis month sales was xx quantity");
                    break;
                case (int)AdminMenu.BalanceSheet:
                    Methods.PrintMessage("In this option you were able to see the whole data of the CarApp");
                    break;
                case (int)AdminMenu.UpdateQuantity:
                    Methods.PrintMessage("Product quantity is updated");
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        public void EmployeeData()
        {
            switch (Validate.Convert<int>("an option"))
            {
                case (int)EmployeeMenu.Login:
                    Methods.PrintMessage("Employee Login Successful...");
                    break;
                case (int)EmployeeMenu.Salary:
                    Methods.PrintMessage($"Salary of name for this month is salary");
                    break;
                case (int)EmployeeMenu.Logout:
                    Methods.PrintMessage("Logout Completed");
                    break;
                default:
                    Methods.PrintMessage("Invalid Option...", false);
                    break;
            }
        }

        public void DesignData()
        {
            Methods.PrintMessage("App is in Progress...", false);
            throw new NotImplementedException();
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
