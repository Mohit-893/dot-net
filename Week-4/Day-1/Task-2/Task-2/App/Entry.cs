using System;
using Task_2.App;

namespace Task_2
{
    class Entry
    {
        static void Main(string[] args)
        {
            try
            {
                //MainApp obj = new MainApp();
                MainApp.firstMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



        }
    }
}
