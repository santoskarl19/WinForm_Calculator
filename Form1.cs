using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Calculator
{
    
    public partial class Form1 : Form
    {
        // instantiate math class
        Addition add = new Addition();
        Subtraction subtract = new Subtraction();
        Multiplication multiply = new Multiplication();
        Division divide = new Division();

        // this will be whatever value is currently on the text screen
        double valueOnScreen = 0;

        // current running total
        double total = 0;

        // stores the button that the user clicks
        string userInput;

        // check if operator was clicked
        bool additionFlag = false;
        bool subtractionFlag = false;
        bool multiplicationFlag = false;
        bool divisionFlag = false;

        bool reset = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtScreen.Text = valueOnScreen.ToString();

        }

        // button 0 function
        private void btn0_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 0; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 1 function
        private void btn1_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 1; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string

        }

        // button 2 function
        private void btn2_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 2; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 3 function
        private void btn3_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 3; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 4 function
        private void btn4_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 4; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 5 function
        private void btn5_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 5; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 6 function
        private void btn6_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 6; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 7 function
        private void btn7_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 7; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 8 function
        private void btn8_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 8; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button 9 function
        private void btn9_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += 9; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // button dot function
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (reset) // if on, reset values to default
            {
                valueOnScreen = 0;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            userInput += "."; // append value as string

            valueOnScreen = double.Parse(userInput); // append input as string

            txtScreen.Text = valueOnScreen.ToString(); // display value as string
        }

        // add function
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // turn on boolean expresion
            additionFlag = true;

            // if reset is on
            if (reset)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            // if addition flag is off
            else if (!additionFlag)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                additionFlag = true;
            }

            //else execute below
            else
            {
                // transfer current value to total
                total += valueOnScreen;

                // reset all value to default
                valueOnScreen = 0;
                userInput = string.Empty;
            }

        }

        // subtract function
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // turn on boolean expresion
            subtractionFlag = true;

            // if reset is on
            if (reset)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            // if addition flag is off
            else if (!subtractionFlag)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                subtractionFlag = true;
            }

            //else execute below
            else
            {
                // transfer current value to total
                total += valueOnScreen;

                // reset all value to default
                valueOnScreen = 0;
                userInput = string.Empty;
            }
        }

        // multiplication function
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // turn on boolean expresion
            multiplicationFlag = true;

            // if reset is on
            if (reset)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            // if addition flag is off
            else if (!multiplicationFlag)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                multiplicationFlag = true;
            }

            //else execute below
            else
            {
                // transfer current value to total
                total += valueOnScreen;

                // reset all value to default
                valueOnScreen = 0;
                userInput = string.Empty;
            }
        }

        // division function
        private void btnDivide_Click(object sender, EventArgs e)
        {
            // turn on boolean expresion
            divisionFlag = true;

            // if reset is on
            if (reset)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                reset = false;
            }

            // if addition flag is off
            else if (!divisionFlag)
            {
                valueOnScreen = total;
                userInput = string.Empty;
                txtScreen.Text = valueOnScreen.ToString();

                divisionFlag = true;
            }

            //else execute below
            else
            {
                // transfer current value to total
                total += valueOnScreen;

                // reset all value to default
                valueOnScreen = 0;
                userInput = string.Empty;
            }
        }

        // display calculation result
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (additionFlag)
            {
                // add object 
                total = add.Calculate(total, valueOnScreen);

                txtScreen.Text = total.ToString();

                reset = true;
                additionFlag = false;
            }
            else if (subtractionFlag)
            {
                // subtract obj 
                total = subtract.Calculate(total, valueOnScreen);

                txtScreen.Text = total.ToString();

                reset = true;
                subtractionFlag = false;
            }
            else if (multiplicationFlag)
            {
                // multiply obj 
                total = multiply.Calculate(total, valueOnScreen);

                txtScreen.Text = total.ToString();

                reset = true;
                multiplicationFlag = false;
            }
            else if(divisionFlag) 
            {
                // divide obj 
                total = divide.Calculate(total, valueOnScreen);

                txtScreen.Text = total.ToString();

                reset = true;
                divisionFlag = false;
            }
        }

        // clear entry function
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            // set everything to default value.
            valueOnScreen = 0;
            total = 0;
            userInput = string.Empty;
            txtScreen.Text = valueOnScreen.ToString();

            additionFlag = false;
            subtractionFlag = false;
            multiplicationFlag = false;
            divisionFlag = false;
            reset = false;
        }
    }
}
