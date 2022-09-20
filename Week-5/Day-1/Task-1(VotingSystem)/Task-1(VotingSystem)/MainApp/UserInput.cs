using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Task_1_VotingSystem_.MainApp
{
    public class UserInput
    {
        public static string GetUserInput(string prompt)
        {
            Console.Write($"Enter {prompt} : ");
            return Console.ReadLine();
        }
        public static T UserrInput<T>(string prompt)
        {
            bool valid = false;
            string userInput;

            while (!valid)
            {
                userInput = GetUserInput(prompt);

                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return default;
        }
    }
}
