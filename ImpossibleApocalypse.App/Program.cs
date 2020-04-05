using ImpossibleApocalypse.Services;
using ImpossibleApocalypse.Shared.Models;
using System;

namespace ImpossibleApocalypse.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.SetConsoleProperties();

            Game.Initialise();

            while (Game.Character.IsDead() == false)
            {
                Game.Intro();
                Game.ChapterOne();
            }

            Game.GameOver();

            Console.ReadKey();
        }
    }
}
