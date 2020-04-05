using ImpossibleApocalypse.Services;
using ImpossibleApocalypse.Shared.Models;
using System;

namespace ImpossibleApocalypse.App
{
    class Program
    {
        public static Character Character = new Character();

        static void Main(string[] args)
        {
            Start();

            Console.ReadKey();
        }

        static void Start()
        {
            Console.Title = "Impossible Apocalypse";
            Text.PrintTitle();

            Text.Print(StandardMessages.WelcomeMessage());
            Utilities.Continue();

            Text.Print(StandardMessages.IntroMessage());
            Utilities.Continue();

            Text.Print(StandardMessages.ChapterOneIntro());
            Events.IncreaseHunger(Character, 2);
        }
    }
}
