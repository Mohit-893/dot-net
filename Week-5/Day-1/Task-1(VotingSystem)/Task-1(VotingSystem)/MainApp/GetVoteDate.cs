using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Task_1_VotingSystem_.MainApp
{
    class GetVoteDate
    {
        internal static string getVoteDate(string aadhar)
        {
            SqlConnection con = new SqlConnection("server=localhost;database=VotingSystem;integrated security=true;");

            string currstate = "";
            string voteDate = "";
            SqlCommand cmd = new SqlCommand("select state_ from VoterList where Aadhar='" + aadhar + "'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currstate = reader["state_"].ToString();
            }
            reader.Close();
            con.Close();
            //SqlDataAdapter da = new SqlDataAdapter("select state_ from VoterList where Aadhar='"+aadhar+"'", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            SqlCommand cmd2 = new SqlCommand("select v_date from VoteDate where state_='" + currstate + "'", con);
            con.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                voteDate = reader2["v_date"].ToString();
            }
            reader2.Close();
            con.Close();
            return voteDate;
        }
    }
}
