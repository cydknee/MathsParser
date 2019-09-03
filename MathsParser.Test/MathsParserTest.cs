using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsParser.Classes;
using System;

namespace MathsParser.Test
{
    [TestClass]
    public class MathsParserTest
    {
        [TestMethod]
        public void Addition()
        {
            //Arrange
            var input = "2a3";
            
            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtraction()
        {
            //Arrange
            var input = "5b2";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void InvalidCharacter()
        {
            //Arrange
            var input = "5x2";

            //Act
            var result = GetInput.ValidateInput(input);

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void SingleBrackets()
        {
            //Arrange
            var input = "2a1ae3a2fb1";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void NestedBrackets()
        {
            //Arrange
            var input = "3a2ce1a2ce3b1fb2f";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void DoubleBrackets()
        {
            //Arrange
            var input = "3ae1a2fbe3a1fa2";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void NegativeTotal()
        {
            //Arrange
            var input = "3b5";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void NegativeTotalInBracket()
        {
            //Arrange
            var input = "2ae3b8f";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void DivideBy0()
        {
            //Arrange
            var input = "3d0";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ExpressionIncludesDecimals()
        {
            //Arrange
            var input = "3.1a2.3";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(Convert.ToDecimal(5.4), result);
        }

        [TestMethod]
        public void ExpressionTooShort()
        {
            //Arrange
            var input = "5a";

            //Act
            var result = GetInput.ValidateInput(input);

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid Expression")]
        public void TwoMathematicalSymbolsNextToEachOther()
        {
            //Arrange
            var input = "6cd2";

            //Act
            ParseMaths.CalculateExpression(input);
        }
    }
}
