using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        startpoint:
            Console.WriteLine("\t\t\t <----- Welcome to My Project ----->\t\t\t");
            Console.WriteLine("\t\t\t Press : \n 1 - Help\n2 - Start\nn3 - setting\nn4 - Exit \n \t\t\t");
            string Start;
            Start = Console.ReadLine();
            if (Start == "1")
            {
                Console.Clear();
                Console.WriteLine("\n=============================Press : *\\n==============================\n");
                string gostart = Console.ReadLine();
                if (gostart == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }
            }
            else if (Start == "2")
            {
                Console.Clear();
                Console.WriteLine("============================\n1-Calculator\n2-  elGadwaldrab\n============================");



               string gostart = Console.ReadLine();
                if (gostart == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }
            }
            else if (Start == "3")
            {
                Console.Clear();
                Console.WriteLine("Setting\\interface\nColour\n*black");
                string interfacechoose = Console.ReadLine();
                if (interfacechoose =="i")
                {
                    Console.Clear();
                    colorsetting:
                    Console.WriteLine("Setting\\interface\n1-White\n2-blue/n3-red\n*-back");
                    string color;
                    color = Console.ReadLine();
                    if (color =="1")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();



                   }
                    if (color == "2")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    if (color == "3")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Clear();
                        goto startpoint;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
