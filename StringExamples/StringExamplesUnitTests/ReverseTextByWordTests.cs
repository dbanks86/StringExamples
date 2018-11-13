using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;

namespace StringExamplesUnitTests
{
    [TestClass]
    public class ReverseTextByWordTests
    {
        [TestMethod]
        public void ReverseTextByWord_TextIsNull_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseTextByWordFunc = () => stringExamples.ReverseTextByWord(null);

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseTextByWordFunc);
        }

        [TestMethod]
        public void ReverseTextByWord_TextIsEmpty_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseTextByWordFunc = () => stringExamples.ReverseTextByWord("");

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseTextByWordFunc);
        }

        [TestMethod]
        public void ReverseTextByWord_TextIsOnlySpaces_ShouldThrowInvalidOperationException()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            Action reverseTextByWordFunc = () => stringExamples.ReverseTextByWord("          ");

            // Assert
            Assert.ThrowsException<InvalidOperationException>(reverseTextByWordFunc);
        }

        [TestMethod]
        public void ReverseTextByWord_TextIsTheBrownFoxIsHungry_ShouldReturnHungryIsFoxBrownFox()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseText = stringExamples.ReverseTextByWord("The brown fox is hungry");

            // Assert
            Assert.AreEqual("hungry is fox brown The", reverseText);
        }

        [TestMethod]
        public void ReverseTextByWord_TextIsFox_ShouldReturnFox()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseText = stringExamples.ReverseTextByWord("Fox");

            // Assert
            Assert.AreEqual("Fox", reverseText);
        }

        [TestMethod]
        public void ReverseTextByWord_TextIsAPeriodBPeriodC_ShouldReturnAPeriodBPeriodC()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseText = stringExamples.ReverseTextByWord("A.B.C");

            // Assert
            Assert.AreEqual("A.B.C", reverseText);
        }

        [TestMethod]
        public void ReverseTextByWord_TextIsAPeriodBPeriodCSpaceCPeriodBPeriodA_ShouldReturnCPeriodBPeriodASpaceAPeriodBPeriodC()
        {
            // Arrange
            StringExamples stringExamples = new StringExamples();

            // Act
            var reverseText = stringExamples.ReverseTextByWord("A.B.C C.B.A");

            // Assert
            Assert.AreEqual("C.B.A A.B.C", reverseText);
        }
    }
}
