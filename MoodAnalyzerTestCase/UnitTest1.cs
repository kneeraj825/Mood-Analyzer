using MoodAnalyzer;
using NUnit.Framework;
using System;
namespace MoodAnalyzerTestCase
{
    [TestFixture]
    public class MoodAnalyser
    {
        [Test]
        public void MoodTest()
        {
            var moodanalyzerproblem = new MoodAnalyzerProblem();
            string result = moodanalyzerproblem.Mood("I am in sad mood");
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void MoodTestHappy()
        {
            var moodanalyzerproblem = new MoodAnalyzerProblem();
            string result = moodanalyzerproblem.Mood("I am in any mood");
            Assert.AreEqual(result, "HAPPY");
        }
        [Test]
        public void No_Parameter_Sad()
        {
            String messgae ="I am in sad mood";
            var moodanalyzerproblem = new MoodAnalyzerProblem(messgae);
            string result = moodanalyzerproblem.Mood();
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void No_Parameter_Happy()
        {
            String messgae = "I am in happy mood";
            var moodanalyzerproblem = new MoodAnalyzerProblem(messgae);
            string result = moodanalyzerproblem.Mood();
            Assert.AreEqual(result, "HAPPY");
        }
        [Test]
        public void Exception_Invalid()
        { 
            var moodanalyzerproblem = new MoodAnalyzerProblem(null);
            string result = moodanalyzerproblem.Mood();
            Assert.AreEqual(result, "HAPPY");
        }
    }  

}