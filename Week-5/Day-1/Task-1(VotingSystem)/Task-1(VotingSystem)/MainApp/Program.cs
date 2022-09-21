using System;
using Task_1_VotingSystem_.MainApp;
using Task_1_VotingSystem_.UI;

namespace Task_1_VotingSystem_
{
    class Program
    {
        public static string aadhar, pan;
        static void Main(string[] args)
        {
            try
            {
                FirstFunc();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }                   
        }

        private static void FirstFunc()
        {
        start:
            Console.Clear();
            aadhar = UserInput.UserrInput<string>("Aadhar Number");
            pan = UserInput.UserrInput<string>("Pancard Number");
            if (Validator.isvaliduser(aadhar, pan))
            {
                string voteDate = GetVoteDate.getVoteDate(aadhar);
                Console.ReadLine();
                if (Validator.isvalidDay(voteDate))
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
                Console.WriteLine("Please Enter correct details");
                Console.ReadLine();
                goto start;
            }
        }

        private static void Voting()
        {
        otpvalidator:
            Console.Clear();
            int otp = GeneratePin.GenerateOTP();
            Console.WriteLine("\nYour OTP for voting is {0}.Kindly remember it for further procedure.", otp);
            Console.ReadLine();
            Functions func = new Functions();
            func.showCandidateList();
            var choice = UserInput.UserrInput<int>("your choice");
            if (Validator.ValidateOTP(otp))
            {
                DBUpdateData.incrementVote(choice);
                DBUpdateData.updateCandidateData(aadhar, pan);
                func.Waiting();
                func.GreetUser();
            }
            else
            {
                Console.WriteLine("\nPlease Enter Correct OTP");
                goto otpvalidator;
            }
        }
    }
}
