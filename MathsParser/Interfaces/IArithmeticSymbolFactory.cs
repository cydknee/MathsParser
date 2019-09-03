namespace MathsParser.Interfaces
{
    interface IArithmeticSymbolFactory
    {
        decimal DoSum(decimal leftValue, decimal rightValue);
    }
}