using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    class DVD : Movie
    {
        public DVD(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes) { }

        public override void Play()
        {
            int sceneNumber;
            int index;
            while (true)
            {
                PrintScene(Scenes);
                string message = "Which scene would you like to watch?";
                sceneNumber = UserInput.CheckIfInt(UserInput.PromptUser(message));
                index = sceneNumber - 1;
                if (sceneNumber > 0 && sceneNumber <= Scenes.Count)
                {
                    Console.WriteLine(Scenes[index]);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter a number from the list.");
                    continue;
                }
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Format: DVD");
            base.PrintInfo();
        }

        public override void PlayWholeMovie()
        {
            int index = 0;
            index = DVDMenu();
            if (index == 1)
            {
                index = 0;
                foreach (string scene in Scenes)
                {
                    Console.WriteLine(Scenes[index]);
                    index++;
                }
            }
            else
            {
                Play();
            }
            Console.WriteLine();
        }

        public int DVDMenu()
        {
            Console.WriteLine($"{Title}\n");
            int input;
            while (true)
            {
                input = UserInput.CheckIfInt(UserInput.PromptUser("1) Play Movie\n2) Scene Select"));
                if (input != 1 && input != 2)
                {
                    Console.WriteLine("Please enter 1 or 2.");
                    continue;
                }
                else if (input == 1)
                {
                    return 1;
                }
                return 2;
            }
        }
    }
}
