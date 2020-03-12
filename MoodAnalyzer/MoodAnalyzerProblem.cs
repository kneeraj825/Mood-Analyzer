using System;

namespace MoodAnalyzer
{
    class MoodAnalyzerProblem
    {
        public String Mood(string message)
        {
            if (message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem");
            MoodAnalyzerProblem moodanalyse = new MoodAnalyzerProblem();
            moodanalyse.Mood("HAPPY");
        }
    }
}
