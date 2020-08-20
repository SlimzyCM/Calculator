using System;
using System.Globalization;
using System.IO;
using CalculatorLibrary.FuncModel.Interfaces;

namespace CalculatorLibrary.FuncModel.Operations
{
    /// <summary>
    /// This class implements the subtraction interface thereby binding to the contract
    /// </summary>
    public class Subtraction : ISubtraction
    {
        //perform the subtract method
        public  string Subtract(string firstNumber, string secondNumber)
        {
            var firstCheck = double.TryParse(firstNumber, out var firstNum);
            var secondCheck = double.TryParse(secondNumber, out var secondNum);

            if (firstCheck && secondCheck)
            {
                var result = Math.Round((firstNum - secondNum), 6).ToString(CultureInfo.InvariantCulture);
                return result;
            }
            throw new InvalidDataException();

            
        }
    }
}
