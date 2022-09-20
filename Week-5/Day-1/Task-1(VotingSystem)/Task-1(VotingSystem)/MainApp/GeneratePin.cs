using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_VotingSystem_.MainApp
{
    public class GeneratePin
    {
        internal static int GenerateOTP()
        {
            Random rnd = new Random();
            int otp = rnd.Next(0001, 9999);
            return otp;
        }
    }
}
