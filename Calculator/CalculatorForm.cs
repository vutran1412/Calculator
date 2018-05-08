using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Calculator;

/*
 * Application: Calculator
 * Author:Vu Tran
 * This is a simple calculator with 
 * Addition, Subtraction, Multiplication, Division, Reciprocal, and SquareRoot functionality
 */

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        // These variables will be assigned according to user input
        public decimal firstNumber;
        public decimal secondNumber;
        public string operation;
        
        // The result of the calculations performed in the Calculator class will be assigned here
        public decimal solution;
        
        // The information that gets displayed in the screen will be stored here
        public string displayString;

        /* The bool newNumber and isDecimal will be used to control entry, whether
        or not the calculator is ready for the next value. The user is able to enter a new numerical
        value after they click any of the operation, the newNumber bool will be set to true, indicating
        the calculator is ready to accept a new calue. The isDecimal bool will be used to restrict the number of
        times a user can click the decimal point, it is set to false after a user clicks the decimal button,
        making it impossible to enter twice*/
        private bool newNumber;
        private bool isDecimal;
        
        // instantiate a new calculator object
        Calculator calculator = new Calculator();

        // The Calculator form laod and initializes the variables
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            firstNumber = 0;
            displayString = firstNumber.ToString();
            newNumber = true;
            isDecimal = false;

        }
        
        // This event handler allows user to click on 0 - 9 keys, and append the button text
        // To the displayString
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (newNumber) // Calculator is ready to accept a new value
            {
                // clears the screen if a new number is ready to be accepted
                displayString = "";
                newNumber = false; // The newNumber is set to false to await user operation selection
                
            }
            // Appends the clicked buttons text to the display string
            displayString += ((Button)sender).Text;
            // Converts and Assigns the value to firstNumber
            firstNumber = Convert.ToDecimal(displayString);
            // Displays the information in the screen
            lblDisplay.Text = firstNumber.ToString();
    
        }
        // The handler for when user clicks the sign button
        private void btnSign_Click(object sender, EventArgs e)
        {
           // Changes the value to negative and vice-versa
           firstNumber = -firstNumber;
           // Displays the information in the screen
           lblDisplay.Text = firstNumber.ToString();
        }

        // The handler for when user clicks on the decimal button
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                // if its a new number, regardless of whether the user clicks 
                // 0 before clicking the decimal button, the screen
                // will still display 0 in front if no other number is clicked.
                displayString = "0";
                newNumber = false;
            }
            // If the nummber doesn't have a decimal point in it
            if (!isDecimal)
            {
                displayString += "."; // Append the decimal to the display string
                // Assign the number with the decimal point to fristNumber and convert the string to decimal
                firstNumber = Convert.ToDecimal(displayString);
                lblDisplay.Text = firstNumber.ToString();
                // Sets the bool value to true, prevents user from creating a value with two decimal points
                isDecimal = true;

            }
        }
        
        // The four event handlers bellow follow the same logic as the btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If its not a new value than assign operator,
            // this is only possible because after user clicks a number on the 
            // calculator the newNumber is set to false
            if (!newNumber)
            {
                // Sets the pending operation to Add
                operation = calculator.Add();
                newNumber = true; // Allows the user to click on a new number on the calculator
                isDecimal = false;
            }
            // Assign the second number clicked on by the user
            secondNumber = Convert.ToDecimal(displayString);
            lblDisplay.Text = secondNumber.ToString();
            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                operation = calculator.Subtract();
                newNumber = true;
                isDecimal = false;
            }
            secondNumber = Convert.ToDecimal(displayString);
            lblDisplay.Text = secondNumber.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                operation = calculator.Multiply();
                newNumber = true;
                isDecimal = false;
            }
            secondNumber = Convert.ToDecimal(displayString);
            lblDisplay.Text = secondNumber.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                operation = calculator.Divide();
                newNumber = true;
                isDecimal = false;
            }
            secondNumber = Convert.ToDecimal(displayString);
            lblDisplay.Text = secondNumber.ToString();
        }

        // The handler for the = button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try // try catch to catch the DivideByZeroException
            {
                // Enters the value into the calculator
                calculator.EnterValue(firstNumber, operation, secondNumber);
                // The Equal Method does the calculation and stores the data in solution
                solution = calculator.Equal();
                // Convert solution to string and display on the screen
                displayString = solution.ToString();
                lblDisplay.Text = displayString;
            } catch (DivideByZeroException)
            {
                // Error message to display on screen
                lblDisplay.Text = "Cannot Divide By Zero.";
                // Resets the calculator and allows user to re-enter a number
                newNumber = true;
                isDecimal = false;
            }
         
        }

        // Handler for the back button
        private void btnBack_Click(object sender, EventArgs e)
        {

            int index;
            // If there is anything displayed at all > 0, 
            // then remove the last number from the displayString
            if (displayString.Length > 0)
            {
                displayString = displayString.Substring(0, displayString.Length - 1);
                index = displayString.Length;
                lblDisplay.Text = lblDisplay.Text.Remove(index - 1, 1);
            }
        }

        // Handler to clear all the data from the calculator form and class
        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            displayString = "";
            firstNumber = 0;
            secondNumber = 0;
            lblDisplay.Text = displayString;
            newNumber = true;
            isDecimal = false;
        }

        // Handler to take the square root of a number, passes the firstNumber as a parameter
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            solution = calculator.SquareRoot(firstNumber);
            displayString = solution.ToString();
            lblDisplay.Text = displayString;
        }

        // Handler to take the reciprocal of a number, passes the firstNumber as a parameter
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try // try catch to handle DivideByZeroException
            {
                solution = calculator.Reciprocal(firstNumber);
                displayString = solution.ToString();
                lblDisplay.Text = displayString;
            } 
            catch (DivideByZeroException)
            {
                lblDisplay.Text = "Cannot Divide By Zero.";
                newNumber = true;
                isDecimal = false;
            }

        }

        // Clears memory 
        private void btnMC_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                MemoryCalculator memCalc = new MemoryCalculator();
                memCalc.MemoryClear();
                newNumber = true;
                isDecimal = false;
            }
        }

        // Recall memory
        private void btnMR_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                MemoryCalculator memCalc = new MemoryCalculator();
                firstNumber = memCalc.MemoryRecall();
                newNumber = true;
                isDecimal = false;
                lblDisplay.Text = memCalc.ToString();
            }
        }

        // Adds the current value to value stored in memory
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                MemoryCalculator memCalc = new MemoryCalculator();
                memCalc.MemoryAdd(firstNumber);
                newNumber = true;
                isDecimal = false;
            }
        }

        // Stores the Calculator's current value in memory
        private void btnMS_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                MemoryCalculator memCalc = new MemoryCalculator();
                memCalc.MemmoryStore(firstNumber);
                newNumber = true;
                isDecimal = false;
            }
        }

    }
}
