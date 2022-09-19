using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_VotingSystem_.UI
{
    class Functions
    {

        public static void showCandidateList()
        {
            Console.Clear();
            Console.WriteLine("\t-------------------------------------------------\t");
            Console.WriteLine("\t|\tPress\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t1 for A\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t2 for B\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t3 for C\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t4 for D\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t5 for E\t\t\t\t\t|\t");
            Console.WriteLine("\t-------------------------------------------------\t");
        }

        internal static void updateCandidateData(string aadhar, string pan)
        {
            // update isvoted to true
        }

        internal static void incrementVote(int choice)
        {
            // increment voterlist table 
        }

        internal static bool isvaliduser(string aadhar, string pan)
        {
            // data match from database 
            // isvoted = false
            return true;
        }
    }
}
