using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MathsParser.Classes
{
    public class ParseMaths 
    {
        public static decimal CalculateExpression(string userInput)
        {
            var regex = new Regex("[e][a-d0-9]*[f]", RegexOptions.IgnoreCase);
            
            while (regex.Matches(userInput).Count != 0)
            {
                foreach (var match in regex.Matches(userInput).Cast<Match>().Reverse())
                {
                    var str = match.Value.Substring(1, (match.Value.Length - 2));
                    userInput = userInput.PositionalReplace(match.Index, match.Length, CalculateAnswer(str));
                }
            }

            return Convert.ToDecimal(CalculateAnswer(userInput));
        }

        private static string CalculateAnswer(string value)
        {
            var strRegex = "(?<=[a-z])(?=-?[0-9])|(?<=-?[0-9])(?=[a-z])";
            var stack = new Stack<string>(Regex.Split(value, strRegex).Reverse());

            while (stack.Count > 1)
            {
                var leftExpression = Convert.ToDecimal(stack.Pop());
                var symbol = stack.Pop();
                var rightExpression = Convert.ToDecimal(stack.Pop());

                IArithmeticSymbolFactory ASymbol = Factory.Get(symbol);
                var total = ASymbol.DoSum(leftExpression, rightExpression);

                stack.Push(total.ToString());
            }

            return stack.Pop().ToString();
        }
    }
}
