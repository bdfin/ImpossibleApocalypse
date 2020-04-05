using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ImpossibleApocalypse.Services
{
    public static class Utilities
    {
        public static void Continue()
        {
            Console.WriteLine();
            Text.Print("Press any key to continue");
            Console.ReadLine();
            SectionBreak();
            Console.Clear();
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
