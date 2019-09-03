using System.Collections.Generic;

namespace MathsParser.Interfaces
{
    public interface IInputManipulation
    {
        string[] SplitUserInput(string userInput);
        Stack<string> ConvertArrayToStack(string[] userInput);
        string ExtractInnerMostBracket(string userInput);
    }
}