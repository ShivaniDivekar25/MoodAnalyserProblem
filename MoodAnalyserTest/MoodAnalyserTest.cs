using MoodAnalyzer;

namespace MoodAnalyserTest
{
    public class MoodAnlyserTest
    {
        [Test]
        public void GivenSadMood_WhenAnalysed_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Sad");
            Assert.Pass();
        }
        [Test]
        public void GivenSadMood_WhenAnalysed_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
            Assert.Pass();
        }
        [Test]
        public void GivenNullMood_WhenAnalysed_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("null");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}
