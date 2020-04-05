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

            ConsoleColor messageColour;

            string message = $"Your hunger has increased by: { hungerAmount }" +
                $"{Environment.NewLine}" +
                $"Your hit points have been reduced to: { character.HitPoints }/100" +
                $"{Environment.NewLine}";

            if (character.Hunger >= 7)
            {
                messageColour = ConsoleColor.Red;

                message += "You are starving. You need to find food soon or you will die.";
            }
            else
            {
                messageColour = ConsoleColor.Yellow;

                message += "You are starting to feel hungry";
            }

            message += Environment.NewLine;

            Console.ForegroundColor = messageColour;
            Console.WriteLine();
            Text.Print(message);
            Console.ResetColor();
        }
    }
}
