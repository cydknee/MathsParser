using System;
using System.Linq;

namespace MathsParser.Classes
{
    public class GetInput
    {
        public static string ReadInput()
        {
            Console.Write("Please enter an expression: ");
            return Console.ReadLine();
        }

        public static bool ValidateInput(string userInput)
        {
            if (userInput.Length < 3)
                return false;

            if (userInput.Count(x => x == 'e') != userInput.Count(x => x == 'f'))
                return false;

            var ReservedCharsArray = Enum.GetNames(typeof(ReservedCharacters)).ToList();
            var invalidChars = userInput.ToCharArray()
                                        .Where(x => !ReservedCharsArray.Contains(x.ToString()) && !char.IsNumber(x))
                                        .ToList();

            if (invalidChars.Count != 0)
                return false;

            return true;
        }
    }
}
