using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserExceptions(MoodAnalyserExceptions.MoodAnalyserExceptionType.EMPTY_MOOD, "Message should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException )
            {
                return "Happy";
                throw new MoodAnalyserExceptions(MoodAnalyserExceptions.MoodAnalyserExceptionType.NULL_MOOD, "Message should not be null");
            }
        }
    }
}
