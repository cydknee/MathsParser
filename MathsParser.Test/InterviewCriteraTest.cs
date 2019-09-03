using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsParser.Interfaces;
using MathsParser.Classes;

namespace MathsParser.Test
{
    [TestClass]
    public class InterviewCriteraTest
    {
        [TestMethod]
        public void Pass_20For3a2c4()
        {
            decimal result = 0;
            string input = "3a2c4";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void Pass_17For32a2d2()
        {
            decimal result = 0;
            string input = "32a2d2";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 17);
        }

        [TestMethod]
        public void Pass_14208For500a10b66c32()
        {
            decimal result = 0;
            string input = "500a10b66c32";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 14208);
        }

        [TestMethod]
        public void Pass_235For3ae4c66fb32()
        {
            decimal result = 0;
            string input = "3ae4c66fb32";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 235);
        }

        [TestMethod]
        public void Pass_990For3c4d2aee2a4c41fc4f()
        {
            decimal result = 0;
            string input = "3c4d2aee2a4c41fc4f";

            input = "e" + input + "f";

            IParseMaths parseMaths = new ParseMaths();
            result = parseMaths.CalculateExpression(input);

            Assert.AreEqual(result, 990);
        }
    }
}
