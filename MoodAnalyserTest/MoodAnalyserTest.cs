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
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenMessage_ThrowMoodAnalyserException_NullMessage()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                string result = moodAnalyser.AnalyseMood();

            }
            catch (MoodAnalyserExceptions moodAnalyserException)
            {
                Assert.AreEqual("Message should not be null", moodAnalyserException.Message);
            }
        }
        [Test]
        public void GivenMessage_ThrowMoodAnalyserException_EmptyMessage()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
                string result = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserExceptions moodAnalyserException)
            {
                Assert.AreEqual("Message should not be Empty", moodAnalyserException.Message);
            }
        }
        [Test]
        public void GivenClassInfo_ShouldReturn_MoodAnalyser()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser", "MoodAnalayser");
                expected.Equals(obj);
            }
            catch (MoodAnalyserExceptions moodAnalyserException)
            {
                Assert.AreEqual("Class not found", moodAnalyserException.Message);
            }
        }
    }
}
