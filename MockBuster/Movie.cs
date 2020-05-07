using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}\nGenre: {Category}\nRun Time: {RunTime} minutes");
        }
        public void PrintScene(List<string> scenes)
        {
            int i = 0;
            foreach (string scene in scenes)
            {
                i++;
                Console.WriteLine($"{i}) {scene}");
            }
        }
        public abstract void Play();

        public abstract void PlayWholeMovie();
    }
}
