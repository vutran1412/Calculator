using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private string displayString;
        private decimal displayValue;

        private bool newValue;
        private bool decimalEntered;

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            displayValue = 0;
            displayString = displayValue.ToString();
            newValue = true;
            decimalEntered = false;
        }

        private void btnNumber_Click(object sender, System.EventArgs e)
        {
            if (newValue)
            {
                displayString = "";
                newValue = false;
            }
            displayString += ((Button)sender).Tag.ToString();
            displayValue = Convert.ToDecimal(displayString);
            lblDisplay.Text = displayValue.ToString();
        }
    }
}
