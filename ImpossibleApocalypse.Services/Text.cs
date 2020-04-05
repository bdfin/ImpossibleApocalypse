using System;
using System.Threading;

namespace ImpossibleApocalypse.Services
{
    public static class Text
    {
        public static void Scroll(string message)
        {
            string[] textLines = message.Split(
                                new[] { Environment.NewLine },
                                StringSplitOptions.None);

            for (int i = 0; i < textLines.Length; i++)
            {
                foreach (char c in textLines[i])
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }

                bool isLastLine = i == textLines.Length - 1;

                if (isLastLine == false)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    WriteSuspentionPoints(500);
                }

                Console.WriteLine();
            }
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
