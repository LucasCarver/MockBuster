using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    class UserInput
    {
        public static string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
        public static string PromptUserInLine(string message)
        {
            Console.Write(message);
            return Console.ReadLine().Trim();
        }

        public static int CheckIfInt(string input)
        {
            int temp;
            try
            {
                temp = int.Parse(input);
                return temp;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                return -1;
            }
        }
    }
}
