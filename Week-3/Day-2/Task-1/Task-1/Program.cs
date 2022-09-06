using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic collection -> able to pass any kind of data(decide kind of data at runtime)  stack,queue
            //normal collection -> arraylist,stack,queue,hash
            //collection ->

            List<string> lst = new List<string>()
            {
                "Mohit","Amit","Shashank"
            };
            //Generic -> define the type at runtime
            foreach(var name in lst)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("");



            HashSet<string> st = new HashSet<string>(); //data should be unique
            st.Add("India");
            st.Add("India");
            st.Add("India");
            st.Add("China");
            foreach (var i in st)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            Stack<int> stck = new Stack<int>();
           
            stck.Push(1);
            stck.Push(2);
            stck.Push(3);
            stck.Pop();
            foreach(var i in stck)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
            foreach(int i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            LinkedList<int> lnkdlst = new LinkedList<int>();
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(2);
            //lnkdlst.AddLast(2);
            //lnkdlst.AddAfter(, 3);
            lnkdlst.RemoveFirst();
            foreach(int i in lnkdlst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            LinkedListNode<int> node = lnkdlst.Find(1);
            lnkdlst.AddAfter(node, 5);
            foreach (int i in lnkdlst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1,"Mohit");
            dict.Add(2, "Mohan");
            dict.Add(3, "Manish");
            dict.Add(4, "Mansi");
            foreach(var i in dict)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("");
            Console.WriteLine(dict.Values.Count);
        }
    }
}

