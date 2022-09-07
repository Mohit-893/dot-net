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
            
                ATMApp atmApp = new ATMApp();
                atmApp.InitializedData();
                atmApp.Run();
        }
    }
}
