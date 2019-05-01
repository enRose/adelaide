using System;
using Adelaide.Intents;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech;

namespace Adelaide
{
    public class Start
    {
        public static void Main(string[] args)
        {
            var recognizer = new IntentRegonisor();

            var actor = new Actor();

            Console.WriteLine("Say something...");

            do
            {
                ContinueRecognise(recognizer, actor);
            }
            while (true);
        }

        public static void ContinueRecognise(IntentRegonisor recognizer, Actor actor)
        {
            var result = recognizer.RecognizeOnce();

            switch (result.Reason)
            {
                case ResultReason.RecognizedIntent:

                    Logger.OnIntentRecognised(result);

                    actor.Do(result);

                    break;

                case ResultReason.RecognizedSpeech:

                    Logger.OnSpeechRecognised(result);

                    break;

                case ResultReason.NoMatch:

                    Logger.OnNoMatch();

                    break;
            }
        }
    }
}
