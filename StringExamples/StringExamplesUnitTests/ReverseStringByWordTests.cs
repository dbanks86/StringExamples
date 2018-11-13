using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;
using System;

namespace StringExamplesUnitTests
{
    [TestClass]
    public class ReverseStringByWordTests
    {
        [TestMethod]
        public void ReverseStringByWord_StringIsNull_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseStringByWordFunc = () => stringExamples.ReverseStringByWord(null);

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseStringByWordFunc);
        }

        [TestMethod]
        public void ReverseStringByWord_StringIsEmpty_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseStringByWordFunc = () => stringExamples.ReverseStringByWord("");

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseStringByWordFunc);
        }

        [TestMethod]
        public void ReverseStringByWord_StringIsOnlySpaces_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseStringByWordFunc = () => stringExamples.ReverseStringByWord("          ");

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseStringByWordFunc);
        }

        [TestMethod]
        public void ReverseStringByWord_StringIsTheBrownFoxIsHungry_ShouldReturnHungryIsFoxBrownFox()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var ReverseString = stringExamples.ReverseStringByWord("The brown fox is hungry");

            // Assert
            Assert.AreEqual("hungry is fox brown The", ReverseString);
        }

        [TestMethod]
        public void ReverseStringByWord_StringIsFox_ShouldReturnFox()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var ReverseString = stringExamples.ReverseStringByWord("Fox");

            // Assert
            Assert.AreEqual("Fox", ReverseString);
        }

        [TestMethod]
        public void ReverseStringByWord_StringIsAPeriodBPeriodC_ShouldReturnAPeriodBPeriodC()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var ReverseString = stringExamples.ReverseStringByWord("A.B.C");

            // Assert
            Assert.AreEqual("A.B.C", ReverseString);
        }

        [TestMethod]
        public void ReverseStringByWord_StringIsAPeriodBPeriodCSpaceCPeriodBPeriodA_ShouldReturnCPeriodBPeriodASpaceAPeriodBPeriodC()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var ReverseString = stringExamples.ReverseStringByWord("A.B.C C.B.A");

            // Assert
            Assert.AreEqual("C.B.A A.B.C", ReverseString);
        }
    }
}
