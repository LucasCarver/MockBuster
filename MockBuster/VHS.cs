using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes) { }

        public override void Play()
        {
            string scene;

            try
            {
                scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            CurrentTime++;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Format: VHS");
            base.PrintInfo();
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

        public override void PlayWholeMovie()
        {
            string input;
            bool needRewind = true;
            if (!(CurrentTime < Scenes.Count))
            {
                while (true)
                {
                    input = UserInput.PromptUserInLine("Somebody forgot to rewind the movie. Rewind now? y/n ").ToLower();
                    Console.WriteLine();
                    if (input != "y" && input != "n")
                    {
                        Console.WriteLine("Invalid entry.");
                        continue;
                    }
                    else if (input == "y")
                    {
                        Rewind();
                    }
                    else
                    {
                        Console.WriteLine("Weird. You said you wanted to watch this movie.");
                        needRewind = false;
                    }
                    break;
                }
            }
            foreach (string scene in Scenes)
            {
                Play();
            }
            Console.WriteLine();
            while (needRewind)
            {
                input = UserInput.PromptUserInLine("The movie has ended. Rewind? y/n ").ToLower();
                Console.WriteLine();
                if (input != "y" && input != "n")
                {
                    Console.WriteLine("Invalid entry.");
                    continue;
                }
                else if (input == "y")
                {
                    Rewind();
                }
                else
                {
                    Console.WriteLine("Rude.");
                    Console.WriteLine();
                }
                break;
            }
        }
    }
}

