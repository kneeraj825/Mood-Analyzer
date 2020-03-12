using System;

namespace MoodAnalyzer
{
    public  class MoodAnalyzerProblem
    {
        public String Mood(string message)
        {
            if (message.Contains("I am in sad mood"))
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
