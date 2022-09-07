using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Task_2_ATM_.Domain.Entities;

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

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.cardNumber = Validate.Convert<long>("your card number.");
            tempUserAccount.cardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN."));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.Write("\nChecking card number and PIN...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to the nearest branch to unlock yout account. Thank you", true);
            Utility.PressEnterTocontinue();
            Environment.Exit(1);
        }

    }
}
