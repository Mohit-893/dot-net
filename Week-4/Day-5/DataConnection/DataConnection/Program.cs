using DataConnection.Models;
using System;
using System.Data.SqlClient;

namespace DataConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("server = localhost; database=StudentTracker; integrated security = true; ");
            try
            {
                connection.Open();

                SqlDataReader reader = null;

                SqlCommand insertCommand = new SqlCommand("insert into Students (StudentId,UserName,FirstName,LastName,EMail,ContactPhone,CreateDate,EditDate) values(2,'pooja.malik','Pooja','Malik','malik.pooja@yahoo.com','8769598758',GETDATE(),GETDATE())", connection);
                
                insertCommand.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("select * from students", connection);

                reader = command.ExecuteReader();

                if(reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Address addr = new Address();

                        Console.WriteLine(String.Format("{0} {1}", reader["FirstName"].ToString(), reader["LastName"].ToString()));
                    }
                }
                else
                {
                    Console.WriteLine("No data available");
                }
               
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
