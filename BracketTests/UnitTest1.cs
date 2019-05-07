using Microsoft.VisualStudio.TestTools.UnitTesting;
using BracketBalance;

namespace BracketTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool correct;
            correct = Brackets.IsBracketBalanced("((1+3)()(4+(3-5)))");
            Assert.IsTrue(correct);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool correct;
            correct = Brackets.IsBracketBalanced("<alpha.Customer[cus_Y4o9qMEZAugtnW] active_card=<alpha.AlphaObject[card}] ...>, created=1324336085, description='Customer for My Test App', livemode=False>");
            Assert.IsFalse(correct);
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool correct;
            correct = Brackets.IsBracketBalanced("a line without brackets at all");
            Assert.IsTrue(correct);
        }
        [TestMethod]
        public void TestMethod4()
        {
            bool correct;
            correct = Brackets.IsBracketBalanced("a line with lots of brackets: <{[(>}])");
            Assert.IsFalse(correct);
        }
    }
}
