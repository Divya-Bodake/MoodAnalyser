namespace MoodAnalyserProblem
{
   
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
