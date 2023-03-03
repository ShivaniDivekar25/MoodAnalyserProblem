using MoodAnalyzer;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyser moodAnalyser = new MoodAnalyser();
        [Test]
        public void GivenSadMood_WhenAnalysed_SholudReturnSad()
        {
            string result = moodAnalyser.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(result, "Sad");
            Assert.Pass();
        }
    }
}