using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.FuncModel.Interfaces
{
    /// <summary>
    /// This interface defines the divide method to be implemented
    /// </summary>
    public interface IDivision
    {
        /// <summary>
        /// This method handles the divide operation 
        /// </summary>
        /// <param name="firstNumber"> the first value of the operation</param>
        /// <param name="secondNumber"> second value for the operation</param>
        /// <returns></returns>
        string Divide(string firstNumber, string secondNumber);
    }
}
