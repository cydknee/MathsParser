using MathsParser.Classes;
using System;

namespace MathsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = GetInput.ReadInput();
            if (GetInput.ValidateInput(userInput))
            {
                Console.WriteLine(ParseMaths.CalculateExpression(userInput));
                Console.Write("Press enter to exit");
                Console.ReadLine();
            }
        }
    }
}
