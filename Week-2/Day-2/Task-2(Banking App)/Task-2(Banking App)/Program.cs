using System;
using System.Data;
using System.Data.SqlClient;

namespace Task_2_Banking_App_
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminData.Admin ad = new AdminData.Admin();
            CustomerData.Customer cs = new CustomerData.Customer();

            SqlConnection con = new SqlConnection("server=localhost;database=banking;integrated security=true;");

            
            int choice = 1;
           // int choice1 = 1;
            //while (Convert.ToBoolean(choice1))
            //{
                Console.Write("Enter Admin id : ");
                ad.id = int.Parse(Console.ReadLine());
                SqlDataAdapter da = new SqlDataAdapter("Select * from admin", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "admin");

                int x = ds.Tables[0].Rows.Count;
                for (int i = 0; i < x; i++)
                {
                    if (ad.id > x)
                    {
                        Console.WriteLine("User does not exist!!!");
                        break;
                    }
                    if (ad.id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                    {
                        Console.Write("Enter username : ");
                        string username = Console.ReadLine();
                        Console.Write("Enter Password : ");
                        string password = Console.ReadLine();
                        if ((username.ToString() == ds.Tables[0].Rows[i][1].ToString()) && (password.ToString() == ds.Tables[0].Rows[i][2].ToString()))
                        {
                            
                            while (Convert.ToBoolean(choice))
                            {
                            Console.Clear();
                                cs.showmenu();
                                int input = int.Parse(Console.ReadLine());
                                switch (input)
                                {
                                    case 1:
                                        Console.Write("Enter Name of Customer : ");
                                        cs.name = Console.ReadLine();
                                        Console.Write("Enter Address of Customer : ");
                                        cs.address = Console.ReadLine();
                                        Console.Write("Enter Account Number of Customer : ");
                                        cs.acc_no = Console.ReadLine();
                                        Console.Write("Enter Phone Number of Customer : ");
                                        cs.phone = double.Parse(Console.ReadLine());
                                        SqlCommand cmd = new SqlCommand("insert into customer values(' " + cs.name + " ',' " + cs.address + " ',' " + cs.acc_no + " ',' " + cs.phone + " ')", con);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        Console.WriteLine("Record inserted successfully");
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter id of Customer to be updated");
                                        int id = int.Parse(Console.ReadLine());

                                        Console.Write("Enter Name of Customer : ");
                                        cs.name = Console.ReadLine();
                                        Console.Write("Enter Address of Customer : ");
                                        cs.address = Console.ReadLine();
                                        Console.Write("Enter Account Number of Customer : ");
                                        cs.acc_no = Console.ReadLine();
                                        Console.Write("Enter Phone Number of Customer : ");
                                        cs.phone = double.Parse(Console.ReadLine());

                                    SqlCommand cmd2 = new SqlCommand("update customer set name='" + cs.name + "',address='" + cs.address + "',acc_no='" + cs.acc_no + "',phone=" + cs.phone + "where id=" + id, con);
                                        con.Open();
                                        cmd2.ExecuteNonQuery();
                                        con.Close();
                                        Console.WriteLine("Record Updated successfully");
                                    break;
                                    case 3:
                                        Console.WriteLine("Enter id of Customer");
                                        cs.id = int.Parse(Console.ReadLine());
                                        SqlCommand cmd1 = new SqlCommand("delete from customer where id=" + cs.id + " ", con);
                                        con.Open();
                                        cmd1.ExecuteNonQuery();
                                        con.Close();
                                        Console.WriteLine("Record deleted successfully");
                                    break;
                                    default:
                                    Console.WriteLine("Please Select a Valid option !!!");
                                        break;
                                }
                                Console.Write("Press 0 to exit\nPress 1-9 to Continue.");
                                choice = int.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Valid Username and Password for id = " + ad.id);
                        }
                    }
                }
                //Console.Write("Press 0 to Change Admin\nPress 1 to Continue with same admin");
                //choice1 = int.Parse(Console.ReadLine());

           // }
            

        }
    }
}
