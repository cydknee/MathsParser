using MathsParser.Interfaces;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MathsParser.Classes
{
    public class InputManipulation : IInputManipulation
    {
        public string[] SplitUserInput(string userInput)
        {
            // split string when char is followed by number and vice versa
            string strRegex = "(?<=[a-z])(?=-?[0-9])|(?<=-?[0-9])(?=[a-z])";
            string[] arrSplitString = Regex.Split(userInput, strRegex);

            return arrSplitString;
        }

        public Stack<string> ConvertArrayToStack(string[] userInput)
        {
            Stack<string> stack = new Stack<string>();

            // add array to stack, stripping brackets at start and end
            for (int i = (userInput.Length - 2); i >= 1; i--)
            {
                stack.Push(userInput[i]);
            }

            return stack;
        }

        public string ExtractInnerMostBracket(string userInput)
        {
            // find last occurence of e and first occurence of f after e
            int startParenthasis = userInput.LastIndexOf('e');
            string str = userInput.Substring(startParenthasis, userInput.Length - startParenthasis);
            int endParenthesis = str.IndexOf('f') + 1;
            string bracketedExpression = userInput.Substring(startParenthasis, endParenthesis);

            return bracketedExpression;
        }
    }
}
