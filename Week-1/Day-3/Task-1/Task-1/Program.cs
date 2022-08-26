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
                    Customerdata.Customer cs = new Customerdata.Customer();
                    cs.enterdata();
                    cs.display();
                    break;
                case 2:
                    Productdata.Product p = new Productdata.Product();
                    p.enterdata();
                    p.display();
                    break;
                case 3:
                    Orderdata.Order o = new Orderdata.Order();
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
