using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        int[] numberTargets = {};
        string[] signs = { };

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.zeroBTN.Text;
        }

        private void oneBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.oneBTN.Text;
        }

        private void twoBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.twoBTN.Text;
        }

        private void threeBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.threeBTN.Text;
        }

        private void fourBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.fourBTN.Text;
        }

        private void fiveBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.fiveBTN.Text;
        }

        private void sixBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.sixBTN.Text;
        }

        private void sevenBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.sevenBTN.Text;
        }

        private void eightBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.eightBTN.Text;
        }

        private void nineBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.nineBTN.Text;
        }

        private void plusBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + this.plusBTN.Text.ToString();
        }

        private void minusBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + " - ";
        }

        private void multiplyBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + " * ";
        }

        private void divideBTN_Click(object sender, EventArgs e)
        {
            this.userInput.Text = this.userInput.Text + " / ";
        }

        private void equalBTN_Click(object sender, EventArgs e)
        {
            string userInput = this.userInput.Text;

            // Remove any white spaces from the user input
            userInput = userInput.Replace(" ", string.Empty);

            // Create a list to store numbers and operators
            List<string> elements = new List<string>();

            // Temporary variable to build the current number
            string currentNumber = string.Empty;

            // Iterate through each character in the user input
            foreach (char c in userInput)
            {
                if (char.IsDigit(c))
                {
                    // If the character is a digit, append it to the current number
                    currentNumber += c;
                }
                else
                {
                    // If the character is an operator, add the current number and operator to the list
                    if (!string.IsNullOrEmpty(currentNumber))
                    {
                        elements.Add(currentNumber);
                        currentNumber = string.Empty;
                    }

                    elements.Add(c.ToString());
                }
            }

            // Add the last number to the list if it exists
            if (!string.IsNullOrEmpty(currentNumber))
            {
                elements.Add(currentNumber);
            }
            double result = double.Parse(elements[0]);

            for (int i = 1; i < elements.Count; i += 2)
            {
                string op = elements[i];
                double operand = double.Parse(elements[i + 1]);

                switch (op)
                {
                    case "+":
                        result += operand;
                        break;

                    case "-":
                        result -= operand;
                        break;

                    case "*":
                        result *= operand;
                        break;

                    case "/":
                        result /= operand;
                        break;

                    default:
                        // Invalid operator
                        break;
                }
            }
            this.userAnswer.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.userInput.Text = "";
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string[] numberToDelete = { };
            string number = string.Empty;
            for(int x = 0; x < this.userInput.Text.Length; x++)
            {
                number = number + this.userInput.Text[x].ToString();
            }

            this.userInput.Text = number;
        }
    }
}
