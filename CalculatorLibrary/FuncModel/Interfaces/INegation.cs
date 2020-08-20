using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.FuncModel.Interfaces
{
    /// <summary>
    /// This interface defines the negation method to be implemented
    /// </summary>
    public interface INegation
    {
        /// <summary>
        /// This method handles the negation operation 
        /// </summary>
        /// <param name="firstNumber"> the value to be negated </param>
        /// <returns></returns>
        string Negate(string firstNumber);
    }
}
