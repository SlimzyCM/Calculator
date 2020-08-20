using System;
using System.Globalization;
using System.IO;
using CalculatorLibrary.FuncModel.Interfaces;

namespace CalculatorLibrary.FuncModel.Operations
{
    /// <summary>
    /// This class implements the division interface thereby binding to the contract
    /// </summary>
    public class Division : IDivision
    {
        //perform division operation
        public string Divide (string firstNumber, string secondNumber)
        {
            if (secondNumber == "0") throw new DivideByZeroException();
            var firstCheck = double.TryParse(firstNumber, out var firstNum);
            var secondCheck = double.TryParse(secondNumber, out var secondNum);

            if (firstCheck && secondCheck)
            {
                var result = Math.Round((firstNum / secondNum), 6).ToString(CultureInfo.InvariantCulture);
                return result;
            }
            throw new InvalidDataException();
        }


    }
}
