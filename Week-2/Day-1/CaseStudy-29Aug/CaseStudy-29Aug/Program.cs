using System;

namespace CaseStudy_29Aug
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 2;
            while (Convert.ToBoolean(choice))
            {
                Console.Clear();
                Console.WriteLine("Enter your Choice :\n1 for register Doctor\n2 for register Patient\n3 for book bed for patient\n0 for exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DoctorRecord.Doctor dc = new DoctorRecord.Doctor();
                        int dchoice = 2;
                        while (Convert.ToBoolean(dchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data\nPress 0 for exit");
                            dchoice = int.Parse(Console.ReadLine());
                            if (dchoice == 1) dc.enter();
                            if (dchoice == 2) dc.display();
                        }
                        break;
                    case 2:
                        PatientRecord.Patient pt = new PatientRecord.Patient();
                        int pchoice = 2;
                        while (Convert.ToBoolean(pchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data\nPress 0 for exit");
                            pchoice = int.Parse(Console.ReadLine());
                            if (pchoice == 1) pt.enter();
                            if (pchoice == 2) pt.display();
                        }
                        break;
                    case 3:
                        BookingRecord.Booking b = new BookingRecord.Booking();
                        int bchoice = 2;
                        while (Convert.ToBoolean(bchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data\nPress 0 for exit");
                            bchoice = int.Parse(Console.ReadLine());
                            if (bchoice == 1) b.enter();
                            if (bchoice == 2) b.display();
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a Valid Choice");
                        break;
                }
            }
            
        }
    }
}
