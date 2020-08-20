using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculatorLibrary.FuncModel.Interfaces;

namespace CalculatorUI
{
    public partial class CalculatorForm : Form
    {
     /// <summary>
     /// The global variables
     /// </summary>
     private readonly IGetResult _getResult;
        private  string _calculatedValue;
        private bool _calculation;
        private readonly List<string> _operationList = new List<string>();

        //Inject the Class library into the constructor of the calculator form
        public CalculatorForm(IGetResult get)
        {
            InitializeComponent();
            this._getResult = get;
        }

        // method handling all the numeric click
        private void buttonNumeric_Handler(object sender, EventArgs e)
        {
            //get the object and cast it to get the button clicked
            var button = (Button) sender;
            try
            {
                //keep form text box in range  
                if(result_Outbox.Text.Length > 15) throw new IndexOutOfRangeException();

                //reset the text box
                if (result_Outbox.Text == "0")
                {
                    result_Outbox.Clear();
                }
                //reset after an operation has occured, clear the text box and set calculation to false
                if (_calculation)
                {
                    result_Outbox.Clear();
                    _calculation = false;
                }
                //Check to ensure only one "." on each text
                if (button.Text == ".")
                {
                    //set the text box text to "0"
                    if (result_Outbox.Text == "") result_Outbox.Text += 0;

                    //check if the text box text already contains a "."
                    if (!result_Outbox.Text.Contains(".")) result_Outbox.Text += button.Text;

                    _calculation = false;
                }
                //reset the text-box text
                else if (_operationList.Count != 0 && _calculation)
                {
                    result_Outbox.Clear();
                    result_Outbox.Text += button.Text;
                    _calculation = false;
                }
                //Populate the text box text with each numeric button pressed 
                else result_Outbox.Text += button.Text;
            }
            //catch exception and display it as a pop up message
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                clearAll();
            }

            
        }
        //Event handler for all operator buttons
        private void buttonOperator_Handler(object sender, EventArgs e)
        {
          
            //cast the object to button
            var button = (Button) sender;

            try
            {
                if (_operationList.Count < 1)
                {
                    _calculatedValue = result_Outbox.Text;
                    _operationList.Add(button.Text);
                    result_Outbox.Clear();
                    return;
                }
                _operationList.Add(button.Text);
                if (_calculation)
                {
                    return;
                }
            
                result_Outbox.Text = _getResult.Calculate(_calculatedValue, result_Outbox.Text, _operationList[^1]);
                _calculatedValue = result_Outbox.Text;
                _calculation = true;

            }
            catch (Exception exception)
            {
                //display exception 
                MessageBox.Show("Error: " + exception.Message);
                //clear calculator variables
                clearAll();
            }
        }
        //Wipe all button handler
        private void buttonC_Handler(object sender, EventArgs e)
        {
            //resets the entire calculator
            clearAll();
        }

        // text delete Button handler
        private void buttonBackSpace_Handler(object sender, EventArgs e)
        {
            // check that the text-box text is not empty or null
            if (!string.IsNullOrEmpty(result_Outbox.Text))
            {
                // use substring method to remove from the end of the string
                result_Outbox.Text = result_Outbox.Text.Length == 1 ? "0" : result_Outbox.Text.Substring(0, result_Outbox.Text.Length - 1);
            }
            
            else result_Outbox.Text = "0";
        }

        //Event handler for the negation button
        private void buttonNegation_Handler(object sender, EventArgs e)
        {
            // get the text-box text and call the negate method in the class library
            result_Outbox.Text = _getResult.Negate(result_Outbox.Text);

        }

        /// <summary>
        /// Method to reset the calculator text-box and all the variables
        /// </summary>
        private void clearAll()
        {
            result_Outbox.Text = "0"; 
           // _operation = "";
           _operationList.Clear();
            _calculatedValue = "0";
        }
        private void buttonEqual_Handler(object sender, EventArgs e)
        {
            if (_operationList.Count == 0 )
            {
                //_calculation = false;
                return;
            }
            try
            {
                //call the calculate method and set the return to the Screen
                result_Outbox.Text = _getResult.Calculate(_calculatedValue, result_Outbox.Text, _operationList[^1]);
                //set operation performed tracer to true so as to reset the input
                _calculation = true;
                //_operation = "";

                //clear the operator list after the operation
                _operationList.Clear();
            }
            catch (Exception exception)
            {
                //display exception 
                MessageBox.Show("Error: " + exception.Message);
                //clear calculator variables
                clearAll();
            }
        }

        //event handler with method for Clear entry
        private void buttonCE_Handler(object sender, EventArgs e)
        {
            //reset the text-box  text
            result_Outbox.Text = "0";
        }


    }
}
