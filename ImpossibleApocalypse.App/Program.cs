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
            Art.GameLogo();

            Text.Print(StandardMessages.WelcomeMessage());
            Utilities.Continue();

            Text.Print(StandardMessages.IntroMessage());
            Utilities.Continue();

            Art.ChapterOneText();
            Art.CampFire();
            Text.Print(StandardMessages.ChapterOneIntro());
            Events.IncreaseHunger(Character, 2);
            Character.ShowStats();
        }
    }
}
