using CalculatorLibrary.FuncModel.Interfaces;
using CalculatorLibrary.FuncModel.Operations;

namespace CalculatorLibrary.FuncModel.Controller
{
    /// <summary>
    /// This class implements the applications operation interface thereby binding to the contract
    /// </summary>
    public class GetResult : IGetResult
    {
        /// <summary>
        /// calculate gets the values and operation to decide the method to call
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="operatorType"> Get the operator and do switch check</param>
        /// <returns></returns>
        public string Calculate(string first, string second, string operatorType)
        {
            string result;

            switch (operatorType)
            {
                case "+":
                    //create an object of the addition class and call the class method
                    var calAddition = new Addition();
                    result = calAddition.Add(first, second);
                    break;

                case "-":
                    //create an object of the class and call the class method
                    var calSubtraction = new Subtraction();
                   result = calSubtraction.Subtract(first, second);
                    break;

                case "*":
                    //create an object of the class and call the class method
                    var calMultiplication = new Multiplication();
                    result = calMultiplication.Multiply(first, second);
                    break;

                case "÷":
                   var calDivision = new Division();
                   result = calDivision.Divide(first, second);
                   break;

                default:
                    result = "";
                    break;
            }

            return result;
        }
        /// <summary>
        /// The method for a single value operation
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string Negate(string num)
        {
            //create an object of the negation class and call the class method
            var callNegation = new Negation();
            return callNegation.Negate(num);
        }

    }
}
