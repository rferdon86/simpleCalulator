using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }
        // Master Calculate Button Method
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal operand1 = Convert.ToDecimal(tboOperand1.Text);
                    decimal operand2 = Convert.ToDecimal(tboOperand2.Text);
                    string operatorValue = tboOperator.Text;
                    decimal result = CalculateResult(operand1, operand2, operatorValue);

                    result = Math.Round(result, 4);
                    tboResult.Text = result.ToString();
                    tboOperand1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }
        //Function to check if data is valid overall
        public bool IsValidData()
        {
            //Validate Operand 1
            if (!IsPresent(tboOperand1, "Operand 1"))
                return false;
            if (!IsDecimal(tboOperand1, "Operand 1"))
                return false;
            if (!IsWithinRange(tboOperand1, "Operand 1", 0, 1000000))
                return false;

            //Validate Operand 2
            if (!IsPresent(tboOperand2, "Operand 2"))
                return false;
            if (!IsDecimal(tboOperand2, "Operand 2"))
                return false;
            if (!IsWithinRange(tboOperand2, "Operand 2", 0, 1000000))
                return false;

            //Validate Operator
            if (!IsOperator(tboOperator, "Operator Value"))
                return false;

            return true;
        }
        //Function to check is operator is either +, -, *, or /
        public bool IsOperator(TextBox textBox, string name)
        {
            string operatorValue = Convert.ToString(textBox.Text);
            if (operatorValue != "+" && operatorValue != "-" && operatorValue != "*" && operatorValue != "/")
            {
                MessageBox.Show(name + " must be either +, -, * or /", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        //Function to check if data is present
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        //Function to check if input is in decimal format
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        //Function to check if input is within acceptable range
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        //Calculation Function
        private decimal CalculateResult(decimal operand1, decimal operand2, string operatorValue)
        {
            decimal result = 0m;

            if (operatorValue == "/")
            {
                result = (operand1 / operand2);
            }
            else if (operatorValue == "*")
            {
                result = (operand1 * operand2);
            }
            else if (operatorValue == "+")
            {
                result = (operand1 + operand2);
            }
            else if (operatorValue == "-")
            {
                result = (operand1 - operand2);
            }

            return result;
        }
        //Clear Text box Method
        private void ClearResult(object sender, EventArgs e)
        {
            tboResult.Text = " ";
        }
        //Exit Program Method
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
