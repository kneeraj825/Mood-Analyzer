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
            var md = new MoodAnalyzerProblem();
            string result = md.Mood("I am in sad mood");
            Assert.AreEqual(result, "SAD");
        }
    }  
}