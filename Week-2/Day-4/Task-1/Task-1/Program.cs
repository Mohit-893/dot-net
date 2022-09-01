using System;

namespace Task_1
{
    class Program
    {
        /*
        // defining delegates
        public delegate double Addnumber1delegate(int no1, float no2, double no3); //Func generic delegate
        public delegate void Addnumber2delegate(int no1, float no2, double no3); //Action generic delegate
        public delegate bool checklengthdelegate(string name); //Predicate generic delicate
        */

        
        //returning function
        public static double Addnumber1(int no1,float no2,double no3)
        {
            return no1 + no2 + no3;
        }
        //pritning function
        public static void Addnumber2(int no1, float no2, double no3)
        {
            Console.WriteLine( no1 + no2 + no3);
        }
        //conditional returning
        public static bool checklength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
        




       /*
        //function delegate
        public delegate void addDelegate(int a, int b);
        public delegate string greetingsDelegate(string name);
       */

        //function add
        public void add(int x, int y)
        {
            Console.WriteLine(@"The sum of {0} and {1} is {2}", x, y, (x + y));
        }
        //function greetings
        public static string Greetings(string name)
        {
            return "Hello " + name;
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            /*
            //instantiating delegates

            addDelegate ad = new addDelegate(obj.add);
            greetingsDelegate gd = new greetingsDelegate(Program.Greetings);

            //invokeing delegates
            
             * ad(100, 200);
            string msg = gd("Mohit");
            Console.WriteLine(msg); */


            /*
            Addnumber1delegate obj1 = new Addnumber1delegate(Addnumber1);
            double result = obj1.Invoke(12, 125.25f, 91.02);
            Console.WriteLine(result);

            Addnumber2delegate obj2 = new Addnumber2delegate(Addnumber2);
            obj2.Invoke(10, 12.5f, 68.03);

            checklengthdelegate obj3 = new checklengthdelegate(checklength);
            bool status = obj3.Invoke("Mahesh");
            Console.WriteLine(status);
            */


            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(Addnumber1);
            double result = obj1.Invoke(10, 20.5f, 12.63);
            Console.WriteLine(result);

            Action<int,float,double> obj2 = new Action<int,float, double>(Addnumber2);
            obj2.Invoke(10,12.5f,63.0);

            Predicate<string> obj3 = new Predicate<string>(checklength);
            bool status = obj3.Invoke("Mohit");
            Console.WriteLine(status);
         }
    }
}
