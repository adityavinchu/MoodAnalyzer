using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MSTestingMood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Moodanalyser_testTC3a()
        {
            string s = null;
            Mood_Analyser mood = new Mood_Analyser(s);
            string moodtype = mood.AnalyseMood();
            Assert.AreEqual("The mood is Null", moodtype);

        }
        [TestMethod]

        public void Moodanalyser_testTC3b()
        {
            string s = "";
            Mood_Analyser mood = new Mood_Analyser(s);
            string moodtype = mood.AnalyseMood();
            Assert.AreEqual("The mood is empty", moodtype);

        }
    }
}