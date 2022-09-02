using System;

namespace OPOverloading
{
    public class Class1
    {
        public int no = 0;
        public Class1(int n)
        {
            no = n;
        }
        public static Class1 operator + (Class1  num1,Class1 num2)
        {
            Class1 num3 = new Class1(0);
            num3.no = num2.no * num1.no;
            return num3;
        }
    }
}
