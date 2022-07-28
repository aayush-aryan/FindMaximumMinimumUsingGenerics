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
        public void TestFirstFloatValue()
        {
            float firstNumber = 8.9f, secondNumber = 4.5f, thirdNumber = 6.7f;
            float expectedValue = firstNumber;
            float actualValue = FindMaximumMinimum.FindMaximumFloatValue(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestSecondFloatValue()
        {
            float firstNumber = 4.5f, secondNumber = 8.9f, thirdNumber = 6.7f;
            float expectedValue = secondNumber;
            float actualValue = FindMaximumMinimum.FindMaximumFloatValue(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestThirdFloatValue()
        {
            float firstNumber = 4.5f, secondNumber = 6.7f, thirdNumber = 8.9f;
            float expectedValue = thirdNumber;

            float actualValue = FindMaximumMinimum.FindMaximumFloatValue(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
