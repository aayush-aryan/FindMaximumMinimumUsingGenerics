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
        public void TestFirstValue()
        {
            int firstNumber = 80, secondNumber = 50, thirdNumber = 67;
            int expectedValue = firstNumber;

            int actualValue = FindMaximumMinimum.FindMaximumInteger(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestSecondValue()
        {
            int firstNumber = 50, secondNumber = 80, thirdNumber = 67;
            int expectedValue = secondNumber;

            int actualValue = FindMaximumMinimum.FindMaximumInteger(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestThirdValue()
        {
            int firstNumber = 50, secondNumber = 80, thirdNumber = 90;
            int expectedValue = thirdNumber;

            int actualValue = FindMaximumMinimum.FindMaximumInteger(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
