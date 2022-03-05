using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MSTestingMood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyzer_case1()
        {
            Program mood = new Program();
            string str =null;
            string moodtype = mood.AnalyzeMood(str);
            Assert.AreEqual("HAPPY", moodtype);
        }

    }
}