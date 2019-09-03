using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsParser.Interfaces;
using MathsParser.Classes;
using System;

namespace MathsParser.Test
{
    [TestClass]
    public class MathsParserTest
    {
        [TestMethod]
        public void Pass_Addition()
        {
            decimal result = 0;
            string input = "2a3";

            input = "e" + input + "f";
            
            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void Pass_Subtraction()
        {
            decimal result = 0;
            string input = "5b2";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Pass_InvalidCharacter()
        {
            bool result = true;
            IGetInput getInput = new GetInput();
            result = getInput.ValidateInput("5x2");

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void Pass_SingleBrackets()
        {
            decimal result = 0;
            string input = "2a1ae3a2fb1";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void Pass_NestedBrackets()
        {
            decimal result = 0;
            string input = "3a2ce1a2ce3b1fb2f";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void Pass_DoubleBrackets()
        {
            decimal result = 0;
            string input = "3ae1a2fbe3a1fa2";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Pass_NegativeTotal()
        {
            decimal result = 0;
            string input = "3b5";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, -2);
        }

        [TestMethod]
        public void Pass_NegativeTotalInBracket()
        {
            decimal result = 0;
            string input = "2ae3b8f";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, -3);
        }

        // TODO: Test waits for console.readline so never completes
        [TestMethod]
        [Ignore]
        [ExpectedException(typeof(DivideByZeroException), "ERROR: Division of 3 by 0.")]
        public void CatchException_DivideBy0()
        {
            decimal result = 0;
            string input = "3d0";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);
        }

        //TODO: Test for decimals in expression

    }
}
