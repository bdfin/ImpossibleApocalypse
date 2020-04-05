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

                if (character.IsDead())
                {
                    message += $"You have succumbed to hunger." +
                        $"{Environment.NewLine}" +
                        $"You struggle to keep your eyes open but conciousness finally fades.";

                    goto DisplayMessage;
                }

                message += "You are starving. You need to eat soon or you will die.";
            }
            else
            {
                messageColour = ConsoleColor.Yellow;

                message += "You are starting to feel hungry";
            }

        DisplayMessage:
            message += Environment.NewLine;
            Console.ForegroundColor = messageColour;
            Console.WriteLine();
            Text.Scroll(message);
            Console.ResetColor();
        }
    }
}
