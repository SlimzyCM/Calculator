using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.FuncModel.Interfaces
{
    /// <summary>
    /// This interface defines the subtract method to be implemented
    /// </summary>
    public interface ISubtraction
    {
        /// <summary>
        /// This method handles the subtract operation 
        /// </summary>
        /// <param name="firstNumber"> the first value </param>
        /// <param name="secondNumber"> second value to be subtracted from the first</param>
        /// <returns></returns>
        string Subtract (string firstNumber, string secondNumber);
    }
}
