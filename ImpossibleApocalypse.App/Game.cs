using ImpossibleApocalypse.Services;
using ImpossibleApocalypse.Shared.Models;
using System;

namespace ImpossibleApocalypse.App
{
    public static class Game
    {
        public static Character Character;

        public static void Initialise()
        {
            Character = new Character();

            Art.GameLogo();

            Text.Scroll(StandardMessages.WelcomeMessage());
            StandardMessages.Continue();
        }

        public static void Intro()
        {
            Utilities.ChangeConsoleTitle("Introduction");

            Text.Scroll(StandardMessages.IntroMessage());
            StandardMessages.Continue();
        }

        public static void ChapterOne()
        {
            Utilities.ChangeConsoleTitle("Chapter 1");

            Art.ChapterOneText();
            Art.CampFire();
            Text.Scroll(StandardMessages.ChapterOneIntro());
            Events.IncreaseHunger(Character, 2);
            Character.ShowStats();
        }

        public static void GameOver()
        {
            Utilities.ChangeConsoleTitle("Game Over");

            Console.Clear();
            Art.GameOver();
        }
    }
}
