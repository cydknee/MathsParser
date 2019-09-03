using MathsParser.Interfaces;
using System;
using System.Collections.Generic;

namespace MathsParser.Classes
{
    public class ParseMaths : IParseMaths
    {
        public decimal CalculateExpression(string userInput)
        {
            decimal total = 0;

            while (userInput.StartsWith("e"))
            {
                IInputManipulation InputManipulation = new InputManipulation();
                string currentExpression = InputManipulation.ExtractInnerMostBracket(userInput);
                string[] arrUserInput = InputManipulation.SplitUserInput(currentExpression);
                Stack<string> stack = InputManipulation.ConvertArrayToStack(arrUserInput);

                total = IterateThroughStack(stack);

                //replace currentexpression with total in userinput
                userInput = userInput.Replace(currentExpression, total.ToString());
            }
            return total;
        }

        private decimal IterateThroughStack(Stack<string> userInput)
        {
            while (userInput.Count > 1)
            {
                userInput = ParsePartialSum(userInput);
            }

            // last item in stack is final total
            return Convert.ToDecimal(userInput.Pop());
        }
        
        private Stack<string> ParsePartialSum(Stack<string> userInput)
        {
            decimal leftExpression = Convert.ToDecimal(userInput.Pop());
            string symbol = userInput.Pop();
            decimal rightExpression = Convert.ToDecimal(userInput.Pop());
            
            decimal total = CalculatePartialSum(leftExpression, rightExpression, symbol);
            userInput.Push(total.ToString());
           
            return userInput;
        }

        private decimal CalculatePartialSum(decimal Left, decimal Right, string Symbol)
        {
            IArithmeticSymbolFactory ASymbol = Factory.Get(Symbol);
            return ASymbol.DoSum(Left, Right);
        }
    }
}
