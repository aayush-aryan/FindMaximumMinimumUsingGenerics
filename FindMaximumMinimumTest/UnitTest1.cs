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
        /// <summary>
        /// test cases for integer value;
        /// </summary>
        [TestMethod]
        public void TestFirstIntegerValue()
        {
            int firstNumber = 80, secondNumber = 50, thirdNumber = 67;
            int expectedValue = firstNumber;
            int actualValue = FindMaximumMinimum.FindMaximumGenericValue<int>(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestSecondIntegerValue()
        {
            int firstNumber = 50, secondNumber = 80, thirdNumber = 67;
            int expectedValue = secondNumber;
            int actualValue = FindMaximumMinimum.FindMaximumGenericValue<int>(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestThirdIntegerValue()
        {
            int firstNumber = 50, secondNumber = 80, thirdNumber = 90;
            int expectedValue = thirdNumber;
            int actualValue = FindMaximumMinimum.FindMaximumGenericValue<int>(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// test cases for float value;
        /// </summary>
        [TestMethod]
        public void TestFirstFloatValue()
        {
            float firstNumber = 8.9f, secondNumber = 4.5f, thirdNumber = 6.7f;
            float expectedValue = firstNumber;
            float actualValue = FindMaximumMinimum.FindMaximumGenericValue<float>(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestSecondFloatValue()
        {
            float firstNumber = 4.5f, secondNumber = 8.9f, thirdNumber = 6.7f;
            float expectedValue = secondNumber;
            float actualValue = FindMaximumMinimum.FindMaximumGenericValue<float>(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestThirdFloatValue()
        {
            float firstNumber = 4.5f, secondNumber = 6.7f, thirdNumber = 8.9f;
            float expectedValue = thirdNumber;

            float actualValue = FindMaximumMinimum.FindMaximumGenericValue<float>(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }

        /// <summary>
        /// test cases for string value;
        /// </summary>
        [TestMethod]
        public void TestFirstStringValue()
        {
            string firstString = "Peach", secondString = "Apple", thirdString = "Bananna";
            string expectedValue = firstString;
            string actualValue = FindMaximumMinimum.FindMaximumGenericValue<string>(firstString, secondString, thirdString);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestSecondStringValue()
        {
            string firstString = "Apple", secondString = "Peach", thirdString = "Bananna";
            string expectedValue = secondString;
            string actualValue = FindMaximumMinimum.FindMaximumGenericValue<string>(firstString, secondString, thirdString);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestThirdStringValue()
        {
            string firstString = "Apple", secondString = "Bananna", thirdString = "Peach";
            string expectedValue = thirdString;
            string actualValue = FindMaximumMinimum.FindMaximumGenericValue<string>(firstString, secondString, thirdString);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
