using System;
using System.Threading;

namespace ImpossibleApocalypse.Services
{
    public static class Text
    {
        public static void Print(string message)
        {
            string[] testLines = message.Split(
                                new[] { Environment.NewLine },
                                StringSplitOptions.None);

            int textScrollDelay = 60;
            int suspentionPointScrollSpeed = 500;

            for (int i = 0; i < testLines.Length; i++)
            {
                foreach (char c in testLines[i])
                {
                    Console.Write(c);
                    Thread.Sleep(textScrollDelay);
                }

                WriteSuspentionPoint(suspentionPointScrollSpeed);

                Console.Write(Environment.NewLine);
            }
        }

        public static void PrintTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(StandardMessages.GameTitle());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.ResetColor();
        }

        private static void WriteSuspentionPoint(int scrollSpeed)
        {
            for (int x = 0; x < 3; x++)
            {
                Console.Write(".");
                Thread.Sleep(scrollSpeed);
            }
        }
    }
}
