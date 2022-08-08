using FindMaximumMinimumProblemUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumMinimumTest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// test cases for integer value;
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerAtFirstPositionShouldReturnTheSameValue()
        {
            int firstNumber = 80, secondNumber = 50, thirdNumber = 67;
            int expectedValue = firstNumber;
            int actualValue = new FindMaximumMinimum<int>(firstNumber, secondNumber, thirdNumber).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxIntegerAtSecondPositionShouldReturnTheSameValue()
        {
            int firstNumber = 50, secondNumber = 80, thirdNumber = 67;
            int expectedValue = secondNumber;
            int actualValue = new FindMaximumMinimum<int>(firstNumber, secondNumber, thirdNumber).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxIntegerAtThirdPositionShouldReturnTheSameValue()
        {
            int firstNumber = 50, secondNumber = 80, thirdNumber = 90;
            int expectedValue = thirdNumber;
            int actualValue = new FindMaximumMinimum<int>(firstNumber, secondNumber, thirdNumber).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }

        /// <summary>
        /// test cases for float value;
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatValueAtFirstPositionShouldReturnTheSameValue()
        {
            float firstNumber = 8.9f, secondNumber = 4.5f, thirdNumber = 6.7f;
            float expectedValue = firstNumber;
            float actualValue = new FindMaximumMinimum<float>(firstNumber, secondNumber, thirdNumber).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxFloatValueAtSecondPositionShouldReturnTheSameValue()
        {
            float firstNumber = 4.5f, secondNumber = 8.9f, thirdNumber = 6.7f;
            float expectedValue = secondNumber;
            float actualValue = new FindMaximumMinimum<float>(firstNumber, secondNumber, thirdNumber).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxFloatValueAtThirdPositionShouldReturnTheSameValue()
        {
            float firstNumber = 4.5f, secondNumber = 6.7f, thirdNumber = 8.9f;
            float expectedValue = thirdNumber;

            float actualValue = new FindMaximumMinimum<float>(firstNumber, secondNumber, thirdNumber).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }


        /// <summary>
        /// test cases for string value;
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtFirstPositionShouldReturnTheSameValue()
        {
            string firstString = "Peach", secondString = "Apple", thirdString = "Bananna";
            string expectedValue = firstString;
            string actualValue = new FindMaximumMinimum<string>(firstString, secondString, thirdString).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GivenMaxStringAtSecondPositionShouldReturnTheSameValue()
        {
            string firstString = "Apple", secondString = "Peach", thirdString = "Bananna";
            string expectedValue = secondString;
            string actualValue = new FindMaximumMinimum<string>(firstString, secondString, thirdString).MaximumValue();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GivenMaxStringAtThirdPositionShouldReturnTheSameValue()
        {
            //Arrange
            string firstString = "Apple", secondString = "Bananna", thirdString = "Peach";
            string expectedValue = thirdString;
            //Act
            string actualValue = new FindMaximumMinimum<string>(firstString, secondString, thirdString).MaximumValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
