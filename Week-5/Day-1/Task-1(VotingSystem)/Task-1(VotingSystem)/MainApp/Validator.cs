using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Task_1_VotingSystem_.MainApp
{
    class Validator
    {

        static SqlConnection con = new SqlConnection("server=localhost;database=VotingSystem;integrated security=true;");

        internal static bool isvalidDay(string voteDate)
        {
            string nowDate = DateTime.Now.ToString("MM/dd/yyyy");
            return (nowDate == voteDate) ? true : false;
        }

        internal static bool ValidateOTP(int otp)
        {
            Console.Write("Enter otp to verify : ");
            int userinp = int.Parse(Console.ReadLine());
            return (userinp == otp) ? true : false;
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
                for (int i = 0; i < x; i++)
                {
                    if ((ds.Tables[0].Rows[i][1].ToString() == aadhar) && (ds.Tables[0].Rows[i][2].ToString() == pan))
                    {
                        if ((int.Parse(ds.Tables[0].Rows[i][4].ToString()) == 0))
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
