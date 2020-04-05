using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ImpossibleApocalypse.Services
{
    public static class Utilities
    {
        public static void SetConsoleProperties()
        {
            ChangeConsoleTitle(null);
            Console.WindowHeight = 37;
        }

        public static void ChangeConsoleTitle(string gameStage)
        {
            if (string.IsNullOrEmpty(gameStage))
            {
                Console.Title = $"Impossible Apocalypse";
            }
            else
            {
                Console.Title = $"Impossible Apocalypse - { gameStage }";
            }
        }

        public static void SectionBreak()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
        }

    }
}
