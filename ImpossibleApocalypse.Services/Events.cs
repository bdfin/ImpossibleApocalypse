using ImpossibleApocalypse.Shared.Models;
using System;

namespace ImpossibleApocalypse.Services
{
    public static class Events
    {
        public static void IncreaseHunger(Character character, int hungerAmount)
        {
            character.Hunger += hungerAmount;
            character.HitPoints -= hungerAmount * 4;

            ConsoleColor messageColour = ConsoleColor.Yellow;

            if (character.Hunger >= 8)
            {
                messageColour = ConsoleColor.Red;
            }

            Console.ForegroundColor = messageColour;

            string message = $"Your hunger has increased by: { hungerAmount }" +
                $"{Environment.NewLine}" +
                $"Your hit points have been reduced to: { character.HitPoints }/100";

            Console.WriteLine();
            Text.Print(message);
            Console.ResetColor();
        }
    }
}
