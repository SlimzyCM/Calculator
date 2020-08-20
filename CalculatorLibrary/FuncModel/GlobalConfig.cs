using CalculatorLibrary.FuncModel.Controller;
using CalculatorLibrary.FuncModel.Interfaces;

namespace CalculatorLibrary.FuncModel
{
    /// <summary>
    /// Global Configuration set up for the calculator object
    /// </summary>
    public static class GlobalConfig
    {
        public static IGetResult ConfigGetResult { get; private set; }
        /// <summary>
        /// Assign the class implement to the instance
        /// </summary>
        /// <returns>A type of the instance </returns>
        public static IGetResult AddConfig()
        {
           var config = new GetResult();
            ConfigGetResult = config;
            return ConfigGetResult;
        }

    }
}
