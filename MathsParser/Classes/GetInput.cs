using MathsParser.Interfaces;
using System;

namespace MathsParser.Classes
{
    public class GetInput : IGetInput
    {
        public string ReadInput()
        {
            Console.Write("Please enter an expression: ");
            
            string input = Console.ReadLine();
            input = "e" + input + "f"; //surround whole expression with brackets so it can be parsed by CalculateExpression()
            return input;
        }

        public bool ValidateInput(string userInput)
        {
            bool isValid = false;
            
            foreach(char c in userInput)
            {
                if (!char.IsNumber(c))
                {
                    isValid = false; //presume each char is invalid until proved otherwise
                    foreach (ReservedCharacters item in Enum.GetValues(typeof(ReservedCharacters)))
                    {
                        if (c.ToString().Equals(item.ToString()))
                        {
                            isValid = true;
                            break;
                        }
                    }

                    if (!isValid)
                    {
                        Console.WriteLine("ERROR: Invalid expression");
                        break;
                    }
                }  
            }

            /*TODO: Validation
             - Check expression has minimum characters
             - Check muliple symbols not adjacent
             - Check opening bracket has corresponding closing bracket*/

            return isValid;
            
        }
    }
}
