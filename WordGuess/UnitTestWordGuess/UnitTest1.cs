using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGuess.Business;
using WordGuess.Utils;

namespace UnitTestWordGuess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuestion()
        {
            Question questionObj = new Question();
            questionObj.GetQuestion();
            questionObj.GetQuestion();
            questionObj.GetQuestion();
            questionObj.GetQuestion();
            Assert.AreEqual(null,questionObj.GetQuestion());
        }

        [TestMethod]
        public void TestAnswer()
        {
            Answer answerObj = new Answer();
            Assert.AreEqual("***", answerObj.GetCorectLetters("abc","bab"));
        }

        [TestMethod]
        public void TestPoint()
        {
            Point pointObj = new Point();

            pointObj.AddPoint();
            pointObj.AddPoint();

            Assert.AreEqual(2, pointObj.GetPoints());
        }

        [TestMethod]
        public void QuestionUtilPoint()
        {
            Assert.AreEqual("srt", "str".Shuffle());
            Assert.AreEqual("rst", "str".Shuffle());
            Assert.AreEqual("rts", "str".Shuffle());
            Assert.AreEqual("tsr", "str".Shuffle());
        }
    }
}
