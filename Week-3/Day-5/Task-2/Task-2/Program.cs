using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task_2
{
    [Serializable]
    class employee
    {
        public int emp_id;
        public string emp_name;
        public employee(int id, string name)
        {
            emp_id = id;
            emp_name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Serialization
            FileStream stream = new FileStream("D:\\serialization.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            //employee emp = new employee(101,"Mansi");
            //formatter.Serialize(stream, emp);
            //stream.Close();

            employee emp = (employee)formatter.Deserialize(stream);
            Console.WriteLine("Employee ID : "+emp.emp_id);
            Console.WriteLine("Employee Name : " + emp.emp_name);




            //DirectoryInfo
            /*
            DirectoryInfo directory = new DirectoryInfo(@"D:\BhavnaCorp");
            try
            {
                //for creating 
                
                if (directory.Exists)
                {
                    Console.WriteLine("Direvtory already exists");
                    return;
                }
                directory.Create();
                Console.WriteLine("Directory is created");
                

                //for directory deletion
                if (directory.Exists)
                {
                    directory.Delete();
                    Console.WriteLine("Directory deleted successfully");
                    return;
                }
                Console.WriteLine("Directory doesnot exists");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
                */


        }
    }
}
