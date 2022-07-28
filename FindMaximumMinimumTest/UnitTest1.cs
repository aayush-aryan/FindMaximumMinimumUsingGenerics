using FindMaximumMinimumProblemUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumMinimumTest
{
    [TestClass]
    public class UnitTest1
    {
        FindMaximumMinimum findMaximumMinimum;

        [TestInitialize]
        public void Setup()
        {
            findMaximumMinimum = new FindMaximumMinimum();
        }
        [TestMethod]
        public void TestFirstStringValue()
        {
            string firstString = "Peach", secondString = "Apple", thirdString = "Bananna";
            string expectedValue = firstString;
            string actualValue = FindMaximumMinimum.FindMaximumStringValue(firstString, secondString, thirdString);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestSecondFloatValue()
        {
            string firstString = "Apple", secondString = "Peach", thirdString = "Bananna";
            string expectedValue = secondString;
            string actualValue = FindMaximumMinimum.FindMaximumStringValue(firstString, secondString, thirdString);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestThirdFloatValue()
        {
            string firstString = "Apple", secondString = "Bananna", thirdString = "Peach";
            string expectedValue = thirdString;

            string actualValue = FindMaximumMinimum.FindMaximumStringValue(firstString, secondString, thirdString);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
