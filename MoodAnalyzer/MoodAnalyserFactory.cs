using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"" + constructorName + "";
            bool result = Regex.IsMatch(className, pattern);
            try
            {
                if (result==true)
                {

                    Assembly excuting = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = excuting.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
            }
            catch (ArgumentException)
            {
                throw new MoodAnalyserExceptions(MoodAnalyserExceptions.MoodAnalyserExceptionType.CLASS_NOT_FOUND, "Class not found");
            }
            return result;
        }
    }
}
