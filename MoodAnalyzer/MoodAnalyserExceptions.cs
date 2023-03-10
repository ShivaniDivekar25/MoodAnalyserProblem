using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserExceptions : Exception
    {
        public enum MoodAnalyserExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
            CLASS_NOT_FOUND,
            NO_SUCH_METHOD
        }
        public MoodAnalyserExceptionType Types;
        public MoodAnalyserExceptions(MoodAnalyserExceptionType Type, string message) : base(message)
        {
            this.Types = Types;
        }
    }
}
