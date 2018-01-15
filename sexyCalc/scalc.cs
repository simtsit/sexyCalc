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

    public partial class Calculator : Form
    {

        double firstNumber = 0;
        double secondNumber = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // textboxMonitor.Clear();
            textboxMonitor.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            // If there is not already a dot...
            textboxMonitor.Text = textboxMonitor.Text + buttonDot.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = firstNumber + double.Parse(textboxMonitor.Text);
            // textboxMonitor.Clear();
            textboxMonitor.Text = "0";
        }


        // If button "Zero" is clicked...
        private void buttonZero_Click(object sender, EventArgs e)
        {
            // If there monitor is not displaying a zero already...
            if (textboxMonitor.Text != "0")
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonZero.Text;
            }
        }


        // Number Buttons
        // These buttons check if monitor displays only 0. In that case
        // the zero is replaced by the number pressed. If not, the digit
        // is added to the right of the number displayed in monitor.
            
        // If button "One" is clicked...
        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "1";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonOne.Text;
            }
        }
        
        // If button "Two" is clicked...
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "2";
            }
            else 
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonTwo.Text;
            }
        }

        // If button "Three" is clicked...
        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "3";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonThree.Text;
            }
        }

        // If button "Four" is clicked...
        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "4";
            }
            else 
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonFour.Text;
            }
        }

        // If button "Five" is clicked...
        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "5";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonFive.Text;
            }
        }

        // If button "Six" is clicked...
        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "6";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonSix.Text;
            }
        }

        // If button "Seven" is clicked...
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "7";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonSeven.Text;
            }

        }

        // If button "Eight" is clicked...
        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "8";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonEight.Text;
            }
        }

        // If button "Nine" is clicked...
        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0")
            {
                textboxMonitor.Text = "9";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonNine.Text;
            }
        }

        private void textboxMonitor_TextChanged(object sender, EventArgs e)
        {

        }


        // When "Equal" button is clicked, the program calculates the result 
        // and reset the monitor back to zero
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondNumber = firstNumber + double.Parse(textboxMonitor.Text);
            textboxMonitor.Text = secondNumber.ToString();
            firstNumber = 0;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
  
        }
    }
}
