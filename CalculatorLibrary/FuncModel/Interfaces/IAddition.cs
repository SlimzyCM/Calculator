using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.FuncModel.Interfaces
{
    /// <summary>
    /// This interface defines the add method to be implemented
    /// </summary>
    public interface IAddition
    {
        /// <summary>
        /// This method handles the add operation 
        /// </summary>
        /// <param name="firstNumber"> the first value to be operated</param>
        /// <param name="secondNumber"> second value to be added with the first</param>
        /// <returns></returns>
        string Add(string firstNumber, string secondNumber);
    }
}
