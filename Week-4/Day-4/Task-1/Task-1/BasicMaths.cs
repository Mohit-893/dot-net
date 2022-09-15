using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class BasicMaths
    {
        public double fact(double a)
        {
            double ans = 1;
            for(int i = 1; i <= a; i++)
            {
                ans = ans * i;
            }
            return ans;
        }
        public bool prime(double a)
        {
            int flag = 0;
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    flag = 0;
                    break;
                }
                else
                    flag = 1;
            }
            if (flag == 1)
                return true;
            else
                return false;
        }
    }
}
