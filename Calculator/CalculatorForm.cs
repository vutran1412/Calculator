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

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        public decimal firstNumber;
        public decimal secondNumber;
        public string operation;
        public decimal solution;
        

        public string displayString;

        private bool newNumber;
        private bool isDecimal;

        Calculator calculator = new Calculator();

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            firstNumber = 0;
            displayString = firstNumber.ToString();
            newNumber = true;
            isDecimal = false;

        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                displayString = "";
                newNumber = false;
                
            }
            displayString += ((Button)sender).Text;
            firstNumber = Convert.ToDecimal(displayString);
            lblDisplay.Text = firstNumber.ToString();
    
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
           firstNumber = -firstNumber;
           lblDisplay.Text = firstNumber.ToString();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                displayString = "0";
                newNumber = false;
            }
            if (!isDecimal)
            {
                displayString += ".";
                firstNumber = Convert.ToDecimal(displayString);
                lblDisplay.Text = firstNumber.ToString();
                isDecimal = true;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!newNumber)
            {
                operation = calculator.Add();
                newNumber = true;
                isDecimal = false;
            }
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

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.EnterValue(firstNumber, operation, secondNumber);
                solution = calculator.Equal();
                displayString = solution.ToString();
                lblDisplay.Text = displayString;
            } catch (DivideByZeroException)
            {
                lblDisplay.Text = "Cannot Divide By Zero.";
                newNumber = true;
                isDecimal = false;
            }
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int index;

            if (displayString.Length > 0)
            {
                displayString = displayString.Substring(0, displayString.Length - 1);
                index = displayString.Length;
                lblDisplay.Text = lblDisplay.Text.Remove(index - 1, 1);
            }
        }

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

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            solution = calculator.SquareRoot(firstNumber);
            displayString = solution.ToString();
            lblDisplay.Text = displayString;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            solution = calculator.Reciprocal(firstNumber);
            displayString = solution.ToString();
            lblDisplay.Text = displayString;
        }
    }
}
