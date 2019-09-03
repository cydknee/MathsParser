namespace MathsParser.Interfaces
{
    public interface IGetInput
    {
        string ReadInput();
        bool ValidateInput(string userInput);
    }
}