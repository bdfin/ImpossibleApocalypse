using System;

namespace ImpossibleApocalypse.Services
{
    public static class StandardMessages
    {
        public static string GameTitle()
        {
            string title = @"
                +-----------------------------------------+
                |-----------------------------------------|
                |-----------------------------------------|
                |--|                                   |--|
                |--|       Impossible Apocalypse       |--|
                |--|                                   |--|
                |-----------------------------------------|
                |-----------------------------------------|
                +-----------------------------------------+";

            return title;
        }

        public static string WelcomeMessage()
        {
            string message = $"Welcome to Impossible Apolcalypse." +
                $"{Environment.NewLine}" +
                $"Try to SURVIVE.";

            return message;
        }

        public static string IntroMessage()
        {
            var virusStartYear = DateTime.UtcNow.Year;
            var startYear = DateTime.UtcNow.AddYears(20).Year;

            string message = $"The year is { startYear }." +
                $"{Environment.NewLine}" +
                $"The world, as humans once knew it, is gone." +
                $"{Environment.NewLine}" +
                $"The virus, first discovered in { virusStartYear }, spread across the globe and couldn't be contained." +
                $"{Environment.NewLine}" +
                $"Civilisation was too slow to adapt. Infrastructure collapsed within months." +
                $"{Environment.NewLine}" +
                $"Wide-spread panic ensued." +
                $"{Environment.NewLine}" +
                $"80% of the world’s population succumbed to the sickness. The immune soon banded together for survival." +
                $"{Environment.NewLine}" +
                $"Some groups remained friendly, holding on to old ways of democracy and compassion." +
                $"{Environment.NewLine}" +
                $"Others less so";

            return message;
        }

        public static string ChapterOneIntro()
        {
            string message = $"It's been 2 days since a small band of looters ambushed your camp and took you prisoner." +
                $"{Environment.NewLine}" +
                $"The smell of cooking vermin meat wafts through the air as you hear the looters laughing around a fire." +
                $"{Environment.NewLine}" +
                $"You notice it's been 3 days since you last ate";

            return message;
        }
    }
}
