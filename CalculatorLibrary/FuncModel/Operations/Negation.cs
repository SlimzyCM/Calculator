using System.Globalization;
using CalculatorLibrary.FuncModel.Interfaces;

namespace CalculatorLibrary.FuncModel.Operations
{
    /// <summary>
    /// This class implements the negation interface thereby binding to the contract
    /// </summary>
    public class Negation : INegation
    {
        //Perform negation operation
        public string Negate(string text)
        {
            double.TryParse(text, out var num);

            return (- + num ).ToString(CultureInfo.InvariantCulture);


        }


    }
}
