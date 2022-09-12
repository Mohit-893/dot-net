using System;
using System.Collections.Generic;
using System.Text;
using Task_2.App;
using Task_2.Domain.Entities;

namespace Task_2.UI
{
    public class Methods
    {
        

        public static void showMainMenu()
        {
            Console.WriteLine("Press\n1-Admin\n2-Employee\n3-Customer");
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void PrintMessage(string msg, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void GetAdminData()
        {
            Console.Clear();
            MainApp mapp = new MainApp();
            string name = Validate.Convert<string>(" admin Name");
            string pass = Validate.Convert<string>(" Password ");
            mapp.ValidateAdmin(name, pass);
        }

        public static void showCarMenu()
        {
            Console.WriteLine("1-Hatchback\n2-Sedan\n3-Mini SUV\n4-SUV");
        }

        public static void showWelcomeScreen(string name)
        {
            Console.Clear();
            Console.WriteLine("-------------Welcome to CARApp---------------");
            Console.WriteLine($"Hi {name}, Please select Car from the given menu");

        }

       /* internal static void GetEmployeeData()
        {
            Console.Clear();
            MainApp mapp = new MainApp();
            string name = Validate.Convert<string>(" Employee Name");
            string pass = Validate.Convert<string>(" Password ");
            mapp.ValidateEmployee(name, pass);
        }
       */

        public static void showEmployeeMenu()
        {
            Console.Clear();
            Console.WriteLine("1-Login\n2-Salary\n3-Logout");
        }
        public static void showAdminMenu()
        {
            Console.Clear();
            Console.WriteLine("1-Add Employee\n2-Total profit\n3-Total Sales\n4-Balance sheet\n5-Update Product Quantity");
        }
    }
}
