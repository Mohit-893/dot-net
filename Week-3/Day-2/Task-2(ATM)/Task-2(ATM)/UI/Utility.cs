using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_ATM_.UI
{
    
    public static class Utility
    {
        public static void PrintMessage(string msg,bool success = true)
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
            PressEnterTocontinue();
        }


        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }


        public static void PressEnterTocontinue()
        {
            Console.WriteLine("\n\nPress Enter to Continue...\n");
            Console.ReadLine();
        }
    }
}
