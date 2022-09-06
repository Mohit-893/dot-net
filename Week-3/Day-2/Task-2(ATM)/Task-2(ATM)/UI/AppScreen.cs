using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_ATM_.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            Console.Title = "ATM App"; // To change Console title

            Console.ForegroundColor = ConsoleColor.White; // sets the text color


            Console.WriteLine("\n\n-----------------Welcome to My ATM App-----------------\n\n");
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate" +
                " a physical ATM card, read the card number and validate it.");
            Utility.PressEnterTocontinue();
        }

       
    }
}
