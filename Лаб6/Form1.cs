using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб6
{
    public partial class Form1 : Form
    {
        double a,b;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void textBox_Info_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar;
            e.Handled = true;
        }
        bool TrySaveA() {
            try
            {
                String[] elements = textBox_Info.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                int lastind = elements.GetUpperBound(0);
                a = double.Parse(elements[lastind]);
                textBox_Info.Clear();
                return true;
            }
            catch(Exception e) {
                textBox_Info.Clear();
                textBox_Info.Text ="Erorr";
                return false;
            }
        }
        private void btn_addition_Click(object sender, EventArgs e)
        {
            if (TrySaveA()) {
                operation = "+";
                textBox_Info.Text = a.ToString() + operation;
            }
        }

        private void btn_substraction_Click(object sender, EventArgs e)
        {
            if (TrySaveA())
            {
                operation = "-";
                textBox_Info.Text = a.ToString() + operation;
            }
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            if (TrySaveA())
            {
                operation = "*";
                textBox_Info.Text = a.ToString() + operation;
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (TrySaveA())
            {
                operation = "/";
                textBox_Info.Text = a.ToString() + operation;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                textBox_Info.Text = textBox_Info.Text + e.KeyChar.ToString();
            }
            else if ((e.KeyChar >= 42 && e.KeyChar <= 47 || e.KeyChar==191) && e.KeyChar!=46 || e.KeyChar==61 || e.KeyChar == 46 || e.KeyChar == 8) {//e.KeyChar == 110
                switch (e.KeyChar) {
                    case '+':
                        btn_addition_Click(sender,e);
                        break;
                    case '-':
                        btn_substraction_Click(sender, e);
                        break;
                    case '*':
                        btn_multiplication_Click(sender, e);
                        break;
                    case '/':
                        btn_division_Click(sender, e);
                        break;
                    case '=':
                        btn_result_Click(sender, e);
                        break;
                    case '.':
                        btn_dot_Click(sender, e);
                        break;
                    case (char)8://backspace
                        btn_CE_Click(sender, e);
                        break;

                }
            }
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 0;

        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 1;
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 2;
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 3;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 4;
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 5;
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 6;
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 7;
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 8;
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + 9;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox_Info.Text ="";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox_Info.Text = textBox_Info.Text + ",";
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                switch (operation)
                {
                    case "+":
                        n = textBox_Info.Text.IndexOf("+");
                        b = a + double.Parse(textBox_Info.Text.Substring(n + 1));
                        textBox_Info.Text = textBox_Info.Text + "=" + Environment.NewLine + b.ToString();
                        operation = "";
                        break;
                    case "-":
                        n = textBox_Info.Text.IndexOf("-");
                        b = a - double.Parse(textBox_Info.Text.Substring(n + 1));
                        textBox_Info.Text = textBox_Info.Text + "=" + Environment.NewLine + b.ToString();
                        operation = "";
                        break;
                    case "*":
                        n = textBox_Info.Text.IndexOf("*");
                        b = a * double.Parse(textBox_Info.Text.Substring(n + 1));
                        textBox_Info.Text = textBox_Info.Text + "=" + Environment.NewLine + b.ToString();
                        operation = "";
                        break;
                    case "/":
                        n = textBox_Info.Text.IndexOf("/");
                        if (double.Parse(textBox_Info.Text.Substring(n + 1)) == 0)
                        {
                            textBox_Info.Text = "Error";
                            operation = "";
                        }
                        else
                        {
                            b = a / double.Parse(textBox_Info.Text.Substring(n + 1));
                            textBox_Info.Text = textBox_Info.Text + "=" + Environment.NewLine + b.ToString();
                            operation = "";
                        }
                        break;

                    default:
                        String[] elements = textBox_Info.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                        int lastind = elements.GetUpperBound(0);
                        textBox_Info.Text = double.Parse(elements[lastind]).ToString();
                        break;
                }
            }
            catch {
                textBox_Info.Text = "Error";
            }

        }
    }
}
