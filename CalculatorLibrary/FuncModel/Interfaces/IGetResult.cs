
namespace CalculatorLibrary.FuncModel.Interfaces
{
    
    /// <summary>
    /// An interface provides a contract for the application operations
    /// </summary>
    public interface IGetResult 
    {
        /// <summary>
        /// methods to call calculate operations and return result
        /// </summary>
        public string Calculate(string firstValue, string secondValue, string operatorType);

        /// <summary>
        /// methods to call negate method and return result
        /// </summary>
        public string Negate(string num);
    }
}
