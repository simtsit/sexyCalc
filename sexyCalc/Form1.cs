using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sexyCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        float firstNumber = 0;
        float secondNumber = 0;

        // With this variable we will be keep tracking on what is the action of the user so
        // program will know what action to perform when user hits "Equal" button. 
        // This check will also prevent crashes or failures when user press multiple times "+", etc.
        // Starting with the "Equal" action as it is neutral.
        String actionPressed = "=";
        String calculatorStatus = "Ready";




        // Notice we are working with Strings (NOT numbers) simulated to work as numbers.
        // The following section describes the actions that take place after the user



        // Button "Clear" --> C
        private void button1_Click(object sender, EventArgs e)
        {
            // When this button is clicked, everything should reset and monitor will show 0.
            textboxMonitor.Text = "0";
        }

        // Button "Divide" --> /
        private void button2_Click(object sender, EventArgs e)
        {
            // If "Divide" button is already pressed, the following code will not be executed.
            // If it was not pressed, then we set the action to "Divide".
            // The check for dividing with zero will be once user hits "Equal"
            if (actionPressed != "/")
            {
                actionPressed = "/";
                firstNumber = firstNumber + float.Parse(textboxMonitor.Text);
                textboxMonitor.Clear();

            }
        }

        // Button "Substract" --> -
        private void buttonSubstruct_Click(object sender, EventArgs e)
        {
            // If "Substract" button is already pressed, the following code will not be executed.
            // If it was not pressed, then we set the action to "Substract" and we do the math work.
            if (actionPressed != "-")
            {
                actionPressed = "-";
                firstNumber = firstNumber + float.Parse(textboxMonitor.Text);
                textboxMonitor.Clear();
            }

        }


        // Button "Multiply" --> x
        private void button3_Click(object sender, EventArgs e)
        {
            // If "Multiply" button is already pressed, the following code will not be executed.
            // If it was not pressed, then we set the action to "Substract" and we do the math work.
            if (actionPressed != "x")
            {
                actionPressed = "x";
                firstNumber = firstNumber + float.Parse(textboxMonitor.Text);
                textboxMonitor.Clear();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Button "Zero" --> 0
        private void buttonZero_Click(object sender, EventArgs e)
        {
            // If monitor is not displaying a zero already, add the zero to the right
            // of whatever monitor shows. This will work fine when we want to type 
            // number 1000 but it will prevent from typing 0001
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "0";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonZero.Text;
            }
            calculatorStatus = "Ready";
        }



        // Numerical Buttons from 1 to 9 have a simple logic:       
        // If Monitor is showing 0, replace it with the pressed number.
        // If not, the digit must be added to the right of current number.

        // Button "One" --> 1
        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "1";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonOne.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Two" --> 2
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "2";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonTwo.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Three" --> 3
        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "3";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonThree.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Four" --> 4
        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "4";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonFour.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Five" --> 5
        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "5";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonFive.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Six" --> 6
        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "6";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonSix.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Seven" --> 7
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "7";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonSeven.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Eight" --> 8
        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "8";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonEight.Text;
            }
            calculatorStatus = "Ready";
        }

        // Button "Nine" --> 9
        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (textboxMonitor.Text == "0" || calculatorStatus == "Finished")
            {
                textboxMonitor.Text = "9";
            }
            else
            {
                textboxMonitor.Text = textboxMonitor.Text + buttonNine.Text;
            }
            calculatorStatus = "Ready";
        }


        // Button "Dot" --> .
        private void buttonDot_Click(object sender, EventArgs e)
        {
            // If there is not already a dot, add it to the end of whatever is shown
            // at monitor. This check will prevent having numbers lie ".012", "0.1.1"
            // and of course "234....". 
            if ((textboxMonitor.Text.Contains(",") == false) && (textboxMonitor.Text != "0"))
            {
                textboxMonitor.Text = textboxMonitor.Text + ","; // buttonDot.Text;
            }
        }

        // Button "Sum" --> +
        private void buttonSum_Click(object sender, EventArgs e)
        {
            // If "Sum" button is already pressed, the following code will not be executed.
            // If it was not pressed, then we set the action to "Sum" and we do the math work.
            if (actionPressed != "+")
            {
                actionPressed = "+";
                firstNumber = firstNumber + float.Parse(textboxMonitor.Text);
                textboxMonitor.Clear();
            }
            
        }

        // Button "Equal" --> =
        // When "Equal" button is clicked, the program calculates the result 
        // and reset the monitor back to zero
        private void buttonEqual_Click(object sender, EventArgs e)
        {

            // In calculators, it is common, when you want to sum something to itself (f.e. 5 + 5 =) 
            // to type "5 + =" . But in our case, if user clicks an action button (f.e. +) and right 
            // after the Equal button, then secondNumber never gets value a proper value. The
            // following code prevents  that from happening by making secondNumber equal to fist 
            // number.
            if (textboxMonitor.Text == "")
            {
                textboxMonitor.Text = firstNumber.ToString();
            }

            switch (actionPressed)
            {
                case "+":
                    // First, calculate the second number and add it to the first number.
                    secondNumber = firstNumber + float.Parse(textboxMonitor.Text);

                    // Then, the result will become the new first number for the upcoming
                    // calculations as a type of String. Right after, firstNumber, which is 
                    // type of Double, will reset to zero.
                    textboxMonitor.Text = secondNumber.ToString();
                    firstNumber = 0;

                    // Return actionPressed to "Equal".
                    actionPressed = "=";
                    break;
                case "-":
                    // First, calculate the second number and substract it from the first number.
                    secondNumber = firstNumber - float.Parse(textboxMonitor.Text);

                    // Then, the result will become the new first number for the upcoming
                    // calculations as a type of String. Right after, firstNumber, which is 
                    // type of Double, will reset to zero.
                    textboxMonitor.Text = secondNumber.ToString();
                    firstNumber = 0;

                    // Return actionPressed to "Equal".
                    actionPressed = "=";

                    break;
                case "x":
                    // First, calculate the second number and then multiply it with the first number.
                    secondNumber = firstNumber * float.Parse(textboxMonitor.Text);

                    // Then, the result will become the new first number for the upcoming
                    // calculations as a type of String. Right after, firstNumber, which is 
                    // type of Double, will reset to zero.
                    textboxMonitor.Text = secondNumber.ToString();
                    firstNumber = 0;

                    // Return actionPressed to "Equal".
                    actionPressed = "=";
                    break;
                case "/":
                    // Prevent dividing with zero.
                    if (textboxMonitor.Text == "0")
                    {
                        textboxMonitor.Text = "1";
                    }

                    // First, calculate the second number and then divide first number with second number.
                    secondNumber = firstNumber / float.Parse(textboxMonitor.Text);

                    // Then, the result will become the new first number for the upcoming
                    // calculations as a type of String. Right after, firstNumber, which is 
                    // type of Double, will reset to zero.
                    textboxMonitor.Text = secondNumber.ToString();
                    firstNumber = 0;

                    // Return actionPressed to "Equal".
                    actionPressed = "=";

                    break;
            }
            calculatorStatus = "Finished";
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
