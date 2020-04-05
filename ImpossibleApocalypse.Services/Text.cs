using System;
using System.Threading;

namespace ImpossibleApocalypse.Services
{
    public static class Text
    {
        public static void Print(string message)
        {
            string[] textLines = message.Split(
                                new[] { Environment.NewLine },
                                StringSplitOptions.None);

            int textScrollDelay = 50;
            int suspentionPointScrollSpeed = 500;

            for (int i = 0; i < textLines.Length; i++)
            {
                foreach (char c in textLines[i])
                {
                    Console.Write(c);
                    Thread.Sleep(textScrollDelay);
                }

                bool isLastLine = i == textLines.Length - 1;

                if (isLastLine == false)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    WriteSuspentionPoints(suspentionPointScrollSpeed);
                }

                Console.WriteLine();
            }
        }

        public static void PrintTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(StandardMessages.GameTitle());
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void WriteSuspentionPoints(int scrollSpeed)
        {
            for (int x = 0; x < 3; x++)
            {
                Console.Write(".");
                Thread.Sleep(scrollSpeed);
            }
        }
    }
}
