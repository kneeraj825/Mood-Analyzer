using System;

namespace MoodAnalyzer
{
    public  class MoodAnalyzerProblem
    {
        String message;
        public MoodAnalyzerProblem()
        {

        }
        public MoodAnalyzerProblem(String message)
        {
            this.message = message;
        }
        public string  Mood(String message)
        {
            this.message = message;
            return Mood();
        }
        public String Mood()
        {
            try
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
            catch (NullReferenceException Null)
            {
                Console.WriteLine(Null);
                return "Invali Mood";
               
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
