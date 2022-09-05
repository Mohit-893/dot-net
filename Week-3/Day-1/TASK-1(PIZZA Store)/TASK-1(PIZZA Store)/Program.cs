using System;
using System.Data;
using System.Data.SqlClient;

namespace TASK_1_PIZZA_Store_
{
    class Program
    {
        public static bool checkadmin(string username,string pass)
        {
            if (username == "admin" && pass == "1234") return true;
            return false;
        }
        public static string ordertype(int n)
        {
            if (n == 1) return "offline";
            if (n == 2) return "online";
            else return " ";
        }



        static void Main(string[] args)
        {
            string username;
            string password;
            string name;

            Admindata.Admin ad = new Admindata.Admin();
            Franchisedata.Employee emp = new Franchisedata.Employee();
            Franchisedata.Sales sle = new Franchisedata.Sales();



            SqlConnection con = new SqlConnection("server=localhost;database=pizza_store;integrated security=true;");

            int input = 1;
            while (Convert.ToBoolean(input))
            {
                Console.WriteLine("Enter 1 for Admin Login\n      2 for Franchise login\n      0 for exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Enter username : ");
                        username = Console.ReadLine();
                        Console.Write("Enter Password : ");
                        password = Console.ReadLine();

                        Func<string, string, bool> dele1 = new Func<string, string, bool>(checkadmin);
                        bool res1 = dele1.Invoke(username, password);

                        if (res1)
                        {
                            int choice = 1;
                            while (Convert.ToBoolean(choice))
                            {
                                ad.showmenu();
                                choice = int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        Console.Write("Enter Franchise Name : ");
                                        ad.f_name = Console.ReadLine();
                                        Console.Write("Enter Franchise Password : ");
                                        ad.pass = Console.ReadLine();

                                        SqlCommand cmd1 = new SqlCommand("insert into franchise values('" + ad.f_name + "','" + ad.pass + "')", con);
                                        con.Open();
                                        cmd1.ExecuteNonQuery();
                                        con.Close();
                                        break;
                                    case 2:
                                        Console.Write("Enter Franchise Name to check Record : ");
                                        ad.f_name = Console.ReadLine();
                                        SqlDataAdapter da1 = new SqlDataAdapter("select * from employee where f_name='" + ad.f_name + "'", con);
                                        DataSet ds1 = new DataSet();
                                        da1.Fill(ds1);
                                        int x = ds1.Tables[0].Rows.Count;
                                        for (int i = 0; i < x; i++)
                                        {
                                            Console.WriteLine(ds1.Tables[0].Rows[i][1].ToString() + " " + ds1.Tables[0].Rows[i][2].ToString() + " " + ds1.Tables[0].Rows[i][3].ToString() + " " + ds1.Tables[0].Rows[i][4].ToString());
                                        }
                                        break;
                                    case 3:
                                        SqlDataAdapter da5 = new SqlDataAdapter("select f_name,sum(price) from sales where o_date = CAST(getdate() as date) group by f_name", con);
                                        DataSet ds5 = new DataSet();
                                        da5.Fill(ds5);
                                        int v = ds5.Tables[0].Rows.Count;
                                        int total_sales = 0;
                                        if (v > 0)
                                        {
                                            for (int j = 0; j < v; j++)
                                            {
                                                Console.WriteLine(ds5.Tables[0].Rows[j][0].ToString() + " " + ds5.Tables[0].Rows[j][1].ToString());
                                                total_sales += int.Parse(ds5.Tables[0].Rows[j][1].ToString());
                                            }
                                            Console.WriteLine("Total Sales : {0}", total_sales);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No Sales for today ...");
                                        }

                                        break;
                                    default:
                                        Console.WriteLine("Enter Valid option only !!!");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.Write("InValid");
                        }
                        break;
                    case 2:
                        Console.Write("Enter franchise name : ");
                        ad.f_name = Console.ReadLine();
                        name = ad.f_name;
                        SqlDataAdapter da2 = new SqlDataAdapter("Select * from franchise", con);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2);
                        int y = ds2.Tables[0].Rows.Count;
                        for (int i = 0; i < y; i++)
                        {
                            //Console.WriteLine(ds2.Tables[0].Rows[i][1].ToString()+" "+ ds2.Tables[0].Rows[i][2].ToString());
                            //Console.WriteLine(name);                      
                            if (name == ds2.Tables[0].Rows[i][1].ToString())
                            {
                                Console.Write("Enter Password : ");
                                ad.pass = Console.ReadLine();
                                if (ad.pass.ToString() == ds2.Tables[0].Rows[i][2].ToString())
                                {
                                    int choice = 1;
                                    while (Convert.ToBoolean(choice))
                                    {
                                        emp.showmenu();
                                        choice = int.Parse(Console.ReadLine());
                                        //Console.WriteLine(choice);
                                        switch (choice)
                                        {
                                            case 0:
                                                break;
                                            case 1:
                                                Console.Write("Enter Employee Name : ");
                                                emp.e_name = Console.ReadLine();
                                                Console.Write("\nEnter Employee Department : ");
                                                emp.e_dept = Console.ReadLine();
                                                Console.Write("\nEnter Employee Salary : ");
                                                emp.e_sal = double.Parse(Console.ReadLine());
                                                SqlCommand cmd2 = new SqlCommand("insert into employee values('" + emp.e_name + "','" + emp.e_dept + "'," + emp.e_sal + ",GETDATE(),'" + name + "')", con);
                                                con.Open();
                                                cmd2.ExecuteNonQuery();
                                                con.Close();
                                                break;
                                            case 2:
                                                Console.Write("Enter Customer Name : ");
                                                sle.c_name = Console.ReadLine();
                                                Console.Write("\nEnter choice 1 for have it here and 2 for take away : ");
                                                int o_type = int.Parse(Console.ReadLine());
                                                Func<int, string> dele2 = new Func<int, string>(ordertype);
                                                sle.o_type = dele2(o_type);
                                                Console.Write("\nEnter employee name : ");
                                                sle.e_name = Console.ReadLine();
                                                Console.Write("\nEnter order value : ");
                                                sle.price = double.Parse(Console.ReadLine());
                                                SqlCommand cmd3 = new SqlCommand("insert into sales values('" + sle.c_name + "','" + sle.o_type + "','" + sle.e_name + "'," + sle.price + ",'" + name + "',GETDATE())", con);
                                                con.Open();
                                                cmd3.ExecuteNonQuery();
                                                con.Close();
                                                break;
                                            case 3:
                                                SqlDataAdapter da3 = new SqlDataAdapter("select * from employee where e_doj <= DATEADD(month,-1,GETDATE()) and f_name='" + name + "'", con);
                                                DataSet ds3 = new DataSet();
                                                da3.Fill(ds3);
                                                int z = ds3.Tables[0].Rows.Count;
                                                if (z <= 0) Console.WriteLine("No Salary distribution for Today ......");
                                                else
                                                {
                                                    for (int j = 0; j < z; j++)
                                                    {
                                                        Console.WriteLine(ds3.Tables[0].Rows[j][1].ToString() + " " + ds3.Tables[0].Rows[j][2].ToString() + " " + ds3.Tables[0].Rows[j][3].ToString() + " " + ds3.Tables[0].Rows[j][4].ToString());
                                                    }
                                                }
                                                break;
                                            case 4:
                                                SqlDataAdapter da4 = new SqlDataAdapter("select * from sales where o_date = CAST(getdate() as date) and f_name='" + name + "'", con);
                                                DataSet ds4 = new DataSet();
                                                da4.Fill(ds4);
                                                int w = ds4.Tables[0].Rows.Count;
                                                if (w <= 0) Console.WriteLine("No Sales for today ......");
                                                else
                                                {
                                                    for (int j = 0; j < w; j++)
                                                    {
                                                        Console.WriteLine(ds4.Tables[0].Rows[j][1].ToString() + " " + ds4.Tables[0].Rows[j][2].ToString() + " " + ds4.Tables[0].Rows[j][3].ToString() + " " + ds4.Tables[0].Rows[j][4].ToString());
                                                    }
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Enter a Valid Choice !!!");
                                                break;
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Wrong Password...");
                                }

                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Enter Choice only from given option ...");
                        break;
                }
            }
        }
    }
}
