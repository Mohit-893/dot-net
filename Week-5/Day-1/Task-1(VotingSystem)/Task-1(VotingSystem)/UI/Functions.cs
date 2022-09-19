using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Task_1_VotingSystem_.UI
{
    class Functions
    {

        static SqlConnection con = new SqlConnection("server=localhost;database=VotingSystem;integrated security=true;");

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
            
            SqlCommand cmd = new SqlCommand("update VoterList set isvoted=1 where Aadhar='"+aadhar+"' and pancard='"+pan+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        internal static void incrementVote(int choice)
        {
            // increment voterlist table  
            SqlCommand cmd = new SqlCommand("update Candidate set votes+=1 where id="+choice, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal static bool isvaliduser(string aadhar, string pan)
        {
            // data match from database 
            // isvoted = false
            SqlDataAdapter da = new SqlDataAdapter("select * from VoterList", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int x = ds.Tables[0].Rows.Count;
            if (x > 0)
            {
                for(int i = 0; i < x; i++)
                {
                    if ((ds.Tables[0].Rows[i][1].ToString() == aadhar) && (ds.Tables[0].Rows[i][2].ToString() == pan))
                    {
                        if ((int.Parse(ds.Tables[0].Rows[i][5].ToString()) == 0))
                            return true;
                        else
                        {
                            Console.WriteLine("User Already Voted!!!");
                            Console.ReadLine();
                        }
                            

                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
