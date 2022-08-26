using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice\n1 for Customer\n2 for Product\n3 for Order");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Customer cs = new Customer();
                    cs.enterdata();
                    cs.display();
                    break;
                case 2:
                    Product p = new Product();
                    p.enterdata();
                    p.display();
                    break;
                case 3:
                    Order o = new Order();
                    o.enterdata();
                    o.display();
                    break;
                default:
                    Console.WriteLine("Please Choose a Valid input !!!");
                    break;
            }
        }
    }
}
