using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0")|| (isOperationPerformed) )
                textBoxResult.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if(!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text;

            }
            else 
            textBoxResult.Text = textBoxResult.Text + button.Text;  
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue!=0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxResult.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
                    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;


             }
            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
           
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
