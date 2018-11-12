using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;

namespace StringExamplesUnitTests
{
    [TestClass]
    public class ReverseStringTests
    {
        [TestMethod]
        public void ReverseString_StringIsEmpty_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseStringFunc = () => stringExamples.ReverseString("");

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseStringFunc);
        }

        [TestMethod]
        public void ReverseString_StringIsHello_ShouldReturn_olleH()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("Hello");

            // Assert
            Assert.AreEqual("olleH", reverseString);
        }

        [TestMethod]
        public void ReverseString_StringIsHeplo_ShouldReturn_olpeH()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("Heplo");

            // Assert
            Assert.AreEqual("olpeH", reverseString);
        }

        [TestMethod]
        public void ReverseString_StringIsHelloWithSpace_ShouldReturn_olleHWithSpace()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("He llo");

            // Assert
            Assert.AreEqual("oll eH", reverseString);
        }

        [TestMethod]
        public void ReverseString_StringIsApples_ShouldReturn_selppA()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("Apples");

            // Assert
            Assert.AreEqual("selppA", reverseString);
        }

        [TestMethod]
        public void ReverseString_StringIsApplesWithSpace_ShouldReturn_selppAWithSpace()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("App les");

            // Assert
            Assert.AreEqual("sel ppA", reverseString);
        }

        [TestMethod]
        public void ReverseString_StringIsApplesTwoSpaces_ShouldReturn_selppAWithTwoSpaces()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("A pple s");

            // Assert
            Assert.AreEqual("s elpp A", reverseString);
        }

        [TestMethod]
        public void ReverseString_StringIsApplesTwoSpacesWithDifferentOppositePositions_ShouldReturn_selppAWithReverseOfTwoSpaces()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseString = stringExamples.ReverseString("A pp les");

            // Assert
            Assert.AreEqual("sel pp A", reverseString);
        }
    }
}
