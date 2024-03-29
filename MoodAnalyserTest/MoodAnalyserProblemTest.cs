using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyse_ShouldReturnSad()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string result = analyser.AnalyseMood("I am in a Sad Mood");
            Assert.AreEqual(result, "Sad");
        }

        [Test]
        public void GivenAnyMood_WhenAnalyse_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyser analyzer = new MoodAnalyser();
            //Act
            string result = analyzer.AnalyseMood("I am in a Any Mood");
            Assert.AreEqual(result, "Happy");
        }
    }
}