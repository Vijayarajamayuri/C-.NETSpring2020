using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCalc
{
      public partial class Form1 : Form
    {
        int firstOperand;
        int secondOperand;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (display.Text.Equals("0"))
            {
                display.Text = "1";
            }
            else
            {
                display.Text += "1";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (display.Text.Equals("0"))
            {
                display.Text = "5";
            }
            else
            {
                display.Text += "5";
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstOperand = Convert.ToInt32(display.Text);
            operation = "+";
            display.Text = display.Text + operation;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            display.Text = "0";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
           String calcuation = display.Text;
            if (operation.Equals("+")){
             int indx =   calcuation.IndexOf("+");
             secondOperand = Convert.ToInt32(calcuation.Substring(indx));
             display.Text = Convert.ToString(firstOperand + secondOperand);
                   
            }
            
        }
    }
}
