using System;
using Task_1_VotingSystem_.UI;

namespace Task_1_VotingSystem_
{
    class Program
    {
        public static string aadhar, pan;
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.Write("Enter Aadhar Number : ");
            aadhar = Console.ReadLine();
            Console.Write("\nEnter PanCard Number : ");
            pan = Console.ReadLine();

            if (Functions.isvaliduser(aadhar,pan))
            {
                string voteDate = Functions.getVoteDate(aadhar);
                if (Functions.isvalidDay(voteDate))
                {
                    Voting();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No Election for today !!!");
                    Console.ReadLine();
                    goto start;
                }               
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please Enter correct details");
                Console.ReadLine();
                goto start;
            }
            
        }

        private static void Voting()
        {
        otpvalidator:
            int otp = Functions.GenerateOTP();
            Console.WriteLine("\nYour OTP for voting is {0}.Kindly remember it for further procedure.", otp);
            Console.ReadLine();
            Functions.showCandidateList();
            var choice = int.Parse(Console.ReadLine());
            if (Functions.ValidateOTP(otp))
            {
                Functions.incrementVote(choice);
                Functions.updateCandidateData(aadhar, pan);
                Functions.Waiting();
                Functions.GreetUser();
            }
            else
            {
                Console.WriteLine("\nPlease Enter Correct OTP");
                goto otpvalidator;
            }
        }
    }
}
