using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Task_2.App;

namespace Task_2.UI
{
    public static class Validate
    {
        public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;

            while (!valid)
            {
                userInput = Methods.GetUserInput(prompt);

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
                    Methods.PrintMessage("Invalid input. Try again", false);
                }
            }
            return default;
        }
    }
}
