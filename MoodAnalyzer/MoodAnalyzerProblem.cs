﻿using System;

namespace MoodAnalyzer
{
    public  class MoodAnalyzerProblem
    {
        string message;
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
