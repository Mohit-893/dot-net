using System;
using Task_2_ATM_.UI;

namespace Task_2_ATM_
{
    class Program
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validate.Convert<long>("your card number");
            Console.WriteLine($"Your name is {cardNumber}");

            Utility.PressEnterTocontinue();

        }
    }
}
