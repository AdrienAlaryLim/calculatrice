using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const char operator_default = ' ';

        private Boolean isError = false;
        private string saisie = null;
        private char operator_str = operator_default; 


        private void button0_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button0.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button2.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(button9.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(buttonPlus.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(buttonMoins.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(buttonMultiplier.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addCharAffichageSaisie(buttonDiviser.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fondE_Click(object sender, EventArgs e)
        {

        }

        private void CalculResultat_Click(object sender, EventArgs e)
        {

        }

        private void affichageSaisie_Click(object sender, EventArgs e)
        {

        }

        private void addCharAffichageSaisie(String s)
        {
            if(affichageSaisie.Text.Equals("0"))
            {
                if (s == "+" || s == "-" || s == "x" || s == "/")
                {
                    char[] charOperator = s.ToCharArray();
                    affichageSaisie.Text = "0" + charOperator[0];
                    setOperatorStr(charOperator[0]);
                }
                else
                {
                    affichageSaisie.Text = s;
                }
            }
            else
            {
                switch (s)
                {
                    case "+":
                        setOperatorStr('+');
                        break;
                    case "-":
                        setOperatorStr('-');
                        break;
                    case "x":
                        setOperatorStr('x');
                        break;
                    case "/":
                        setOperatorStr('/');
                        break;
                    default:
                        break;
                }
                affichageSaisie.Text += s;
            }
        }

        private void setOperatorStr(char c)
        {
            if(operator_str == operator_default)
            {
                operator_str = c;
            }
            else
            {
                affichageResultat.Text = "Err. 2 opérateurs saisis";
                isError = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clearAffichageSaisie();
        }

        private void clearAffichageSaisie()
        {
            if(affichageSaisie.Text == "0")
            {
                affichageResultat.Text = "0";
            }
            affichageSaisie.Text = "0";

            saisie = null;
            operator_str = operator_default;
        }

        private void calculate()
        {

            if (operator_str == operator_default)
            {
                affichageResultat.Text = "Err. opérateur null";
                isError = true;
            }
            else
            {
                string[] numbers = affichageSaisie.Text.Split(operator_str);

                if (numbers[0] == null)
                {
                    affichageResultat.Text = "Err. nb 1 est null";
                    isError = true;
                }
                
                if (numbers[1] == null || numbers[1] == "")
                {
                    affichageResultat.Text = "Err. nb 2 est null";
                    isError = true;
                }

                if(isError == false)
                {

                int number1 = Int32.Parse(numbers[0]);
                int number2 = Int32.Parse(numbers[1]);
                int result = 0;

                switch (operator_str)
                {
                    case '+':
                        result = number1 + number2;
                        affichageResultat.Text = result.ToString();
                        break;
                    case '-':
                        result = number1 - number2;
                        affichageResultat.Text = result.ToString();
                        break;
                    case 'x':
                        result = number1 * number2;
                        affichageResultat.Text = result.ToString();
                        break;
                    case '/':
                        if (number2 == 0)
                        {
                            affichageResultat.Text = "Err. div 0 impossible";
                        }
                        else
                        {
                            result = number1 / number2;
                            affichageResultat.Text = result.ToString();
                        }
                        break;
                    default:
                        affichageResultat.Text = "Err. calcul";
                        break;
                    }
                }
            }
        }
      
    }
}
