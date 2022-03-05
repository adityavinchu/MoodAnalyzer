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
            string moodtype = mood.AnalyzeMood("I am in SAD mood");
            Assert.AreEqual("SAD", moodtype);
        }

        public void MoodAnalyzer_case2()
        {
            Program mood = new Program();
            string moodtype = mood.AnalyzeMood("I am in HAPPY mood");
            Assert.AreEqual("HAPPY", moodtype);
        }
    }
}