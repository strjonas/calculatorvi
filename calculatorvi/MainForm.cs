using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorvi
{
    public partial class MainForm : Form
    {

        String Calculation = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void handle(String msg)
        {
            Calculation = Calculation + msg;
            label1.Text = Calculation;
        }

        private void calculate()
        {

            Double ergebnis = 0;
            String temp = "0";
            char op = '+';
            foreach(char s in Calculation)
            {
                switch (s)
                {
                    case '+':
                        switch (op)
                        {
                            case '+':
                                ergebnis = ergebnis + Convert.ToDouble(temp);
                                temp = "";
                                break;
                            case '-':
                                ergebnis = ergebnis - Convert.ToDouble(temp);
                                temp = "";
                                break;
                        }
                        op = '+';
                        break;
                    case '-':
                        switch (op)
                        {
                            case '+':
                                ergebnis = ergebnis + Convert.ToDouble(temp);
                                temp = "";
                                break;
                            case '-':
                                ergebnis = ergebnis - Convert.ToDouble(temp);
                                temp = "";
                                break;
                        }
                        op = '-';
                        break;

                    case '/':
                        switch (op)
                        {
                            case '+':
                                ergebnis = ergebnis + Convert.ToDouble(temp);
                                temp = "";
                                break;
                            case '-':
                                ergebnis = ergebnis - Convert.ToDouble(temp);
                                temp = "";
                                break;
                        }
                        temp = "";
                        break;
                    default:
                        temp += s;
                        break;

                }
            }
            Calculation = Convert.ToString(ergebnis);
            label1.Text = Calculation;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            Calculation = "+" + Calculation + "/";
            calculate();   
        }
        private void button0_Click(object sender, EventArgs e)

        {
            handle("0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            handle("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            handle("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            handle("3");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            handle("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            handle("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            handle("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            handle("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            handle("9");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            handle("4");
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Calculation = "";
            label1.Text = Calculation;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (Calculation.Length < 1) { return; };
            if (Calculation.EndsWith("-") || Calculation.EndsWith("+")) { return; };
            handle("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Calculation.Length < 1) { return; };
            if (Calculation.EndsWith("-") || Calculation.EndsWith("+")) { return; };
            handle("+");
        }
    }
}
