using MathsParser.Classes;
using MathsParser.Interfaces;
using System;

namespace MathsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput; 

            //Start Program
            IGetInput getInput = new GetInput();
            userInput = getInput.ReadInput();
            while (getInput.ValidateInput(userInput) == false)
            {
                userInput = getInput.ReadInput();
            }

            //got here so input must be valid
            IParseMaths parseMaths = new ParseMaths();
            Console.WriteLine(parseMaths.CalculateExpression(userInput));
            
            //Keep Console Box open
            Console.Write("Press any key to exit");
            Console.ReadLine();
        }
    }
}
