using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.FuncModel.Interfaces
{
    /// <summary>
    /// This interface defines the multiply method to be implemented
    /// </summary>
    public interface IMultiplication
    {
        /// <summary>
        /// This method handles the multiplication operation 
        /// </summary>
        /// <param name="firstNumber"> the first value </param>
        /// <param name="secondNumber"> second value to be multiplied with the first</param>
        /// <returns></returns>
        string Multiply(string firstNumber, string secondNumber);
    }
}
