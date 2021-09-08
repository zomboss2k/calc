using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Le_Tien_Dat
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool sign;

        public Form1()
        {
            InitializeComponent();
            sign = true;

        }

        private void number_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (isOperationPerformed))
                result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + button.Text;

            }
            else
                result.Text = result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                equals.PerformClick();
                operationPerformed = button.Text;
                lastString.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(result.Text);
                lastString.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }        

        private void plusMin_Click(object sender, EventArgs e)
        {
            if (sign)
            {
                result.Text = "-" + result.Text;
                sign = false;
            }
            else
            {
                result.Text = result.Text.Replace("-", "");
                sign = true;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
                    switch (operationPerformed)
                    {
                        case "+":
                            result.Text = (resultValue + Double.Parse(result.Text)).ToString();
                            break;
                        case "-":
                            result.Text = (resultValue - Double.Parse(result.Text)).ToString();
                            break;
                        case "*":
                            result.Text = (resultValue * Double.Parse(result.Text)).ToString();
                            break;
                        case "/":
                            result.Text = (resultValue / Double.Parse(result.Text)).ToString();
                            break;
                        default:
                            break;
                    }
                
                resultValue = Double.Parse(result.Text);
                lastString.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            lastString.Text = "";
            resultValue = 0;

        }

        private void clearLast_Click(object sender, EventArgs e)
        {
            int len = result.Text.Length - 1;
            string text = result.Text;
            result.Clear();

            for (int i = 0; i < len; i++)
                result.Text = result.Text + text[i];

            if (result.Text == "")
                result.Text = "0";
        }

        private void purcent_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    result.Text = (resultValue + ((resultValue * (Double.Parse(result.Text)))/100.0)).ToString();
                    break;
                case "-":
                    result.Text = (resultValue - ((resultValue * (Double.Parse(result.Text))) / 100.0)).ToString();
                    break;
                case "*":
                    result.Text = (resultValue * ((resultValue * (Double.Parse(result.Text))) / 100.0)).ToString();
                    break;
                case "/":
                    result.Text = (resultValue / ((resultValue * (Double.Parse(result.Text))) / 100.0)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(result.Text);
            lastString.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

