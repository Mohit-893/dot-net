using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Order :Classid, Idisplay, Ienterdata
    {
        double trackingno;
        string paymentdetails;
        string shipmentdetails;
        public void display()
        {
            Console.WriteLine("Order details are :\norder id -> "+id+"\nTracking number ->"+trackingno+"\nPayment details -> "+paymentdetails+"\nShipment details -> "+shipmentdetails);
        }

        public void enterdata()
        {
            Console.Write("Enter Order Id : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Tracking Number : ");
            trackingno = double.Parse(Console.ReadLine());
            Console.Write("Enter Payment details : ");
            paymentdetails = Console.ReadLine();
            Console.Write("Enter Shipment details : ");
            shipmentdetails = Console.ReadLine();
        }
    }
}
