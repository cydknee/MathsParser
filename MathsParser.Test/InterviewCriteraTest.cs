using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsParser.Classes;

namespace MathsParser.Test
{
    [TestClass]
    public class InterviewCriteraTest
    {
        [TestMethod]
        public void Expression3a2c4()
        {
            //Arrange
            var input = "3a2c4";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Expression32a2d2()
        {
            //Arrange
            var input = "32a2d2";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void Expression500a10b66c32()
        {
            //Arrange
            var input = "500a10b66c32";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(14208, result);
        }

        [TestMethod]
        public void Expression3ae4c66fb32()
        {
            //Arrange
            var input = "3ae4c66fb32";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(235, result);
        }

        [TestMethod]
        public void Expression3c4d2aee2a4c41fc4f()
        {
            //Arrange
            var input = "3c4d2aee2a4c41fc4f";

            //Act
            var result = ParseMaths.CalculateExpression(input);

            //Assert
            Assert.AreEqual(990, result);
        }
    }
}
