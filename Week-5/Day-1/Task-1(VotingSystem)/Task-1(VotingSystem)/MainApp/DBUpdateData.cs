using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Task_1_VotingSystem_.MainApp
{
    class DBUpdateData
    {
        static SqlConnection con = new SqlConnection("server=localhost;database=VotingSystem;integrated security=true;");
        internal static void updateCandidateData(string aadhar, string pan)
        {
            // update isvoted to true

            SqlCommand cmd = new SqlCommand("update VoterList set isvoted=1 where Aadhar='" + aadhar + "' and pancard='" + pan + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        internal static void incrementVote(int choice)
        {
            // increment voterlist table  
            SqlCommand cmd = new SqlCommand("update Candidate set votes+=1 where id=" + choice, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
