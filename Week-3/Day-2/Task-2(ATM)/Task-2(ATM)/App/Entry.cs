using System;
using System.Collections.Generic;
using System.Text;
using Task_2_ATM_.UI;

namespace Task_2_ATM_.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            ATMApp atmApp = new ATMApp();

            atmApp.InitializedData();
            atmApp.CheckUserCardNumAndPassword();
            atmApp.Welcome();

            //long cardNumber = Validate.Convert<long>("your card number");
            //Console.WriteLine($"Your name is {cardNumber}");

            Utility.PressEnterTocontinue();

        }
    }
}
