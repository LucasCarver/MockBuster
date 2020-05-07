using System;

namespace MockBuster
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Movie movieSelection;
            bool exitCondition = false;
            while (true)
            {
                Movie movie = Blockbuster.CheckOut(Blockbuster.Movies);
                if (movie == null)
                {
                    while (true)
                    {
                        Console.WriteLine();
                        input = UserInput.PromptUserInLine("Are you sure you want to exit? y/n ").ToLower();
                        Console.WriteLine();
                        if (input != "y" && input != "n")
                        {
                            Console.WriteLine("Invalid entry.");
                            continue;
                        }
                        else if (input == "y")
                        {
                            exitCondition = true;
                        }
                        else
                        {
                            exitCondition = false;
                        }
                        break;
                    }
                    if (!exitCondition)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    input = UserInput.PromptUserInLine("Do you want to watch this movie? y/n ").ToLower();
                    Console.WriteLine();
                    if (input != "y" && input != "n")
                    {
                        Console.WriteLine("Invalid entry.");
                        continue;
                    }
                    else if (input == "y")
                    {
                        movie.PlayWholeMovie();
                    }
                    break;
                }
            }
            Console.WriteLine("Thank you for using MockBuster.");
        }
    }
}
