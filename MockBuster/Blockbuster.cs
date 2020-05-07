using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    class Blockbuster
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>()
        {
            new VHS("Shrek", Genre.Comedy, 95,
                new List<string>(){ "Somebody once told me...",
                                    "Get out of my swamp!",
                                    "When we get home, I'm making waffles.",
                                    "Pick number 3 my lord!" } ),

            new VHS("Willy Wonka & the Chocolate Factory", Genre.Horror, 100,
                new List<string>(){ "Charlie visits a candy shop.",
                                    "Charlie gets a golden ticket.",
                                    "Augustus falls into the chocolate river.",
                                    "Violet blows up into a large blueberry.",
                                    "Veruca demands a golden goose.",
                                    "Mike teleports himself." } ),

            new VHS("Donnie Darko", Genre.Drama, 113,
                new List<string>(){ "I'm voting for Dukakis.",
                                    "Wake up, Donnie.",
                                    "Don't worry. You got away with it.",
                                    "Do you believe in time travel?",
                                    "Have you ever seen a portal?" } ),

            new VHS("2001: A Space Odyssey", Genre.Scifi, 142,
                new List<string>(){ "Monkeys find the monolith.",
                                    "Humans find the monolith.",
                                    "Humans journey to Jupiter.",
                                    "HAL2000 kills everyone except Bowman.",
                                    "Bowman kills HAL2000.",
                                    "Bowman enters a new dimension.",
                                    "Bowman's life flashes before his eyes.",
                                    "Starchild approaches Earth." } ),

            new DVD("Mad Max: Fury Road", Genre.Action, 120,
                new List<string>(){ "Max wrecks his car.",
                                    "Immortan Joe gives a speech.",
                                    "Furiosa drives into a sandstorm.",
                                    "Furiosa scams the bikers.",
                                    "Swamp problems.",
                                    "Backtracking." } ),

            new DVD("The Shining", Genre.Horror, 144,
                new List<string>(){ "Arriving at the Overlook Hotel.",
                                    "Hallorann describes shining.",
                                    "Danny and Wendy explore the hedge maze.",
                                    "Jack meets a bartender.",
                                    "All work and no play makes Jack a dull boy.",
                                    "REDRUM." } ),

            new DVD("Inception", Genre.Drama, 148,
                new List<string>(){ "First extraction.",
                                    "Getting the team together.",
                                    "Flight inception.",
                                    "Warehouse inception.",
                                    "Van inception.",
                                    "Hotel inception.",
                                    "Bunker inception.",
                                    "Limbo inception.",
                                    "The kicks.",
                                    "Ambiguous conclusion." } )
        };

        public Blockbuster() { }

        public static void PrintMovies(List<Movie> movies)
        {
            int index;
            string title;
            for (int i = 0; i < movies.Count; i++)
            {
                index = i + 1;
                title = movies[i].Title;

                Console.WriteLine($"{index}) {title}");
            }
            Console.WriteLine("0) Exit Menu");
        }

        public static Movie CheckOut(List<Movie> movies)
        {
            int temp;
            int index;
            while (true)
            {
                PrintMovies(movies);
                Console.WriteLine();
                temp = UserInput.CheckIfInt(UserInput.PromptUserInLine("Which movie would you like to check out? "));
                if (temp == 0)
                {
                    return null;
                }
                index = temp - 1;
                if (temp > 0 && temp <= movies.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter a number from the list.");
                    Console.WriteLine();
                    continue;
                }
            }
            Console.WriteLine();
            movies[index].PrintInfo();
            Console.WriteLine();
            return movies[index];

        }
    }
}
