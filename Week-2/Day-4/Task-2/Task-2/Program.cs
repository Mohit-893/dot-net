using System;
using System.Data;
using System.Data.SqlClient;

namespace Task_2
{
   
    class Program
    {
        static int loc;

        public static bool Isavail(int n)
        {   
            if (n != -1) return true;
            return false;
        }


        public static bool Ischeck(string id, string pass)
        {
            if (id == "root" && pass == "1234")
                return true;
            return false;
        }

        public static void show(int id, string name, double price, string category)
        {
            Console.WriteLine(id + " " + name + " " + price + " " + category);
        }






        static void Main(string[] args)
        {
            
            ProductData.Product p = new ProductData.Product();

            SqlConnection con = new SqlConnection("server=localhost;database=fashionStore;integrated security=true;");

            Console.Write("Enter Username : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password : ");
            string pass = Console.ReadLine();

            Func<string,string,bool> obj = new Func<string,string,bool>(Ischeck);
            bool status = obj.Invoke(username,pass);
            if (status)
            {
                
                int choice = 1;
                while (Convert.ToBoolean(choice))
                {
                    p.showmenu();
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            break;
                        case 1:


                            Console.Write("Enter Product Name : ");
                            p.name = Console.ReadLine();
                            Console.Write("\nEnter Product Price : ");
                            p.price = double.Parse(Console.ReadLine());
                            Console.Write("\nEnter Category ID : ");
                            p.category_id = int.Parse(Console.ReadLine());


                            SqlCommand cmd = new SqlCommand("insert into product values(' " + p.name + " ',' " + p.price + " ',' " + p.category_id + " ')", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            
                            break;
                        case 2:
                            Console.Write("Enter Product Id of Product you want to Delete : ");
                            p.id = int.Parse(Console.ReadLine());
                            SqlCommand cmd1 = new SqlCommand("delete from product where p_id=" + p.id + " ", con);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            
                            break;
                        case 3:
                            Console.WriteLine("Enter Product Id of Product you want to Update : ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Enter Product Name : ");
                            p.name = Console.ReadLine();
                            Console.Write("\nEnter Product Price : ");
                            p.price = double.Parse(Console.ReadLine());
                            Console.Write("\nEnter Category ID : ");
                            p.category_id = int.Parse(Console.ReadLine());

                            SqlCommand cmd2 = new SqlCommand("update product set p_name='" + p.name + "',p_price=" + p.price + ",c_id= " + p.category_id + "where p_id=" + id, con);
                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            
                            break;
                        case 4:
                            Console.Write("Enter Product ID you want to Serach : ");
                            id = int.Parse(Console.ReadLine());

                            SqlDataAdapter da = new SqlDataAdapter("select * from product", con);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            int x = ds.Tables[0].Rows.Count;
                            for (int i = 0; i < x; i++)
                            {
                                if (id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                                {
                                    loc = i;
                                    break;
                                   // Console.Write(loc);
                                }
                                else
                                {
                                    loc = -1;
                                }
                            }

                            Predicate<int> obj1 = new Predicate<int>(Isavail);
                            bool avail = obj1.Invoke(loc);

                            if (avail)
                            {
                                p.name = ds.Tables[0].Rows[loc][1].ToString();
                                p.price = double.Parse(ds.Tables[0].Rows[loc][2].ToString());
                                p.category_id = int.Parse(ds.Tables[0].Rows[loc][3].ToString());


                                SqlDataAdapter adap = new SqlDataAdapter("select * from category", con);
                                DataSet ds1 = new DataSet();
                                adap.Fill(ds1);
                                int y = ds1.Tables[0].Rows.Count;
                                for (int i = 0; i < y; i++)
                                {
                                    if (p.category_id.ToString() == ds1.Tables[0].Rows[i][0].ToString())
                                    {
                                        p.category = ds1.Tables[0].Rows[i][1].ToString();
                                    }
                                }

                                Action<int, string, double, string> print = new Action<int, string, double, string>(show);
                                print.Invoke(id,p.name,p.price,p.category);
                                
                            }
                            else
                            {
                                Console.WriteLine("Product id not available !!!");
                            }

                            break;
                        default:
                            Console.WriteLine("Enter the correct choice !!!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Correct Data");
            }
        }
    }
}
