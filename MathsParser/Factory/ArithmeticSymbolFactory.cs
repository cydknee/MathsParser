using System;

namespace MathsParser.Classes
{
    interface IArithmeticSymbolFactory
    {
        decimal DoSum(decimal leftValue, decimal rightValue);
    }

    public abstract class ArithmeticSymbolFactory : IArithmeticSymbolFactory
    {
        public abstract decimal DoSum(decimal leftValue, decimal rightValue);
    }

    public class Addition : ArithmeticSymbolFactory
    {
        public override decimal DoSum(decimal leftValue, decimal rightValue)
        {
            return leftValue + rightValue;
        }
    }

    public class Subtraction : ArithmeticSymbolFactory
    {
        public override decimal DoSum(decimal leftValue, decimal rightValue)
        {
            return leftValue - rightValue;
        }
    }

    public class Multiplication : ArithmeticSymbolFactory
    {
        public override decimal DoSum(decimal leftValue, decimal rightValue)
        {
            return leftValue * rightValue;
        }
    }

    public class Division : ArithmeticSymbolFactory
    {
        public override decimal DoSum(decimal leftValue, decimal rightValue)
        {
            try
            {
                return leftValue / rightValue;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR: Division of {0} by 0.", leftValue);
                Console.WriteLine("Press enter key to exit application");
                return 0;
            }
        }
    }

    static class Factory
    {
        public static ArithmeticSymbolFactory Get(string symbol)
        { 
            switch (symbol)
            {
                case "a":
                    return new Addition();
                case "b":
                    return new Subtraction();
                case "c":
                    return new Multiplication();
                case "d":
                    return new Division();
                default:
                    throw new Exception("Invalid Expression");
            }
        }
    }
}
