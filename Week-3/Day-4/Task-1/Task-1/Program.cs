using System;
using System.Reflection;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = typeof(object).Module.Assembly;

            /* Type[] types2 = a.GetTypes();
             foreach (Type t in types2)
             {
                 Console.WriteLine(t.FullName);
             }
            */
            
            /*
             * Type t = typeof(System.String);
            Console.WriteLine("Listing all the public constructors of the {0} type", t);
            // Constructors.
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("//Constructors");
            PrintMembers(ci);
            */


            Console.WriteLine("Reflection.MethodInfo");
            
            Type myType = Type.GetType("System.Reflection.FieldInfo");
            
            MethodInfo myMethodInfo = myType.GetMethod("GetValue");
            Console.WriteLine(myType.FullName + "." + myMethodInfo.Name);
            
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
           else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }
            

        }
        public static void PrintMembers(MemberInfo[] ms)
        {
            foreach (MemberInfo m in ms)
            {
                Console.WriteLine("{0}{1}", "     ", m);
            }
            Console.WriteLine();
        }
    }
}
