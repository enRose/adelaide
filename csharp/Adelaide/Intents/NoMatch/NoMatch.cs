using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.Intents
{
    public static class NoMatch
    {
        public static string[] speeches = {
                "CannotHelp",
                "DoNotKnowHowTo",
                "NoSkillsToHandle"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            Utils.RandomlyPlay(speeches, "NoMatch");
        }
    }
}
