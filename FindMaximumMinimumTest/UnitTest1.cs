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
            //Arrange
            int[] integerArray = { 43, 33, 23, 13 };
            int expectedValue = 43;
            //Act
            int actualValue = new FindMaximumMinimum<int>(integerArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxIntegerAtSecondPositionShouldReturnTheSameValue()
        {
            //Arrange
            int[] integerArray = { 33, 43, 23, 13 };
            int expectedValue = 43;
            //Act
            int actualValue = new FindMaximumMinimum<int>(integerArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxIntegerAtThirdPositionShouldReturnTheSameValue()
        {
            //Arrange
            int[] integerArray = { 23, 33, 43, 13 };
            int expectedValue = 43;
            //Act
            int actualValue = new FindMaximumMinimum<int>(integerArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaxIntegerAtFourthPositionShouldReturnTheSameValue()
        {
            //Arrange
            int[] integerArray = { 13, 33, 23, 43 };
            int expectedValue = 43;
            //Act
            int actualValue = new FindMaximumMinimum<int>(integerArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// method for checking float value;
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtFirstPositionShouldReturnTheSameValue()
        {
            //Arrange
            float[] floatArray = { 4.3f, 3.3f, 2.3f, 1.3f };
            float expectedValue = 4.3f;
            //Act
            float actualValue = new FindMaximumMinimum<float>(floatArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// method for checking float value;
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtSecondPositionShouldReturnTheSameValue()
        {
            //Arrange
            float[] floatArray = { 3.3f, 4.3f, 2.3f, 1.3f };
            float expectedValue = 4.3f;
            //Act
            float actualValue = new FindMaximumMinimum<float>(floatArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// method for checking float value;
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtThirdPositionShouldReturnTheSameValue()
        {
            //Arrange
            float[] floatArray = { 2.3f, 3.3f, 4.3f, 1.3f };
            float expectedValue = 4.3f;
            //Act
            float actualValue = new FindMaximumMinimum<float>(floatArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// method for checking float value;
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtFourthPositionShouldReturnTheSameValue()
        {
            //Arrange
            float[] floatArray = { 1.3f, 3.3f, 2.3f, 4.3f };
            float expectedValue = 4.3f;
            //Act
            float actualValue = new FindMaximumMinimum<float>(floatArray).MaxValue();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void GivenMaximumStringValueAtFirstPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            string[] stringArray = { "Peach", "Apple", "Bannana", "Grapes" };
            string expected = "Peach";
            /// Act
            string actualValue = new FindMaximumMinimum<string>(stringArray).MaxValue();
            /// Assert
            Assert.AreEqual(expected, actualValue);
        }
        [TestMethod]
        public void GivenMaximumStringValueAtSecondPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            string[] stringArray = { "Apple", "Peach", "Bannana", "Grapes" };
            string expected = "Peach";
            /// Act
            string actualValue = new FindMaximumMinimum<string>(stringArray).MaxValue();
            /// Assert
            Assert.AreEqual(expected, actualValue);
        }
        [TestMethod]
        public void GivenMaximumStringValueAtThirdPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            string[] stringArray = { "Bannana", "Apple", "Peach", "Grapes" };
            string expected = "Peach";
            /// Act
            string actualValue = new FindMaximumMinimum<string>(stringArray).MaxValue();
            /// Assert
            Assert.AreEqual(expected, actualValue);
        }
        [TestMethod]
        public void GivenMaximumStringValueAtFourthPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            string[] stringArray = { "Grapes", "Apple", "Bannana", "Peach" };
            string expected = "Peach";
            /// Act
            string actualValue = new FindMaximumMinimum<string>(stringArray).MaxValue();
            /// Assert
            Assert.AreEqual(expected, actualValue);
        }
    }
}
