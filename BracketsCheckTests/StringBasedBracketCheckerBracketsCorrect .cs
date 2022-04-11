using BracketsCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketsCheckTests
{
    [TestClass]
    public class StringBasedBracketCheckerTests
    {
        private StringBasedBracketChecker checker = new StringBasedBracketChecker();

        [TestMethod]
        public void BracketsCheckerCommon()
        {
            Assert.AreEqual(checker.BracketsCorrect("{[()]}"), true);
            Assert.AreEqual(checker.BracketsCorrect("{(})"), false);
            Assert.AreEqual(checker.BracketsCorrect("{[(])}"), false);
            Assert.AreEqual(checker.BracketsCorrect("{{[[(())]]}}"), true);
            Assert.AreEqual(checker.BracketsCorrect("[(])"), false);
            Assert.AreEqual(checker.BracketsCorrect("[({})](]"), false);
        }

        [TestMethod]
        public void BracketsCheckerOtherSymbols()
        {
            Assert.AreEqual(checker.BracketsCorrect(""), true);
            Assert.AreEqual(checker.BracketsCorrect("pepa"), true);
            Assert.AreEqual(checker.BracketsCorrect("(pepa)"), true);
            Assert.AreEqual(checker.BracketsCorrect("10 * [123 + 7 (6 + 2)]"), true);
            Assert.AreEqual(checker.BracketsCorrect("10 * [123 + 7 (6 + 2))"), false);
        }

        [TestMethod]
        public void BracketsCheckerMultipleEndings()
        {
            Assert.AreEqual(checker.BracketsCorrect("(){}[]"), true);
            Assert.AreEqual(checker.BracketsCorrect("(]"), false);
        }
    }
}