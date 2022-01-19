using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int a = Convert.ToInt32(n / 100);
            int b = Convert.ToInt32(n % 10);
            int c = Convert.ToInt32(n % 100);
            int c1 = Convert.ToInt32(c / 10);
            {
                if (a == b & b == c1 & a == c1)
                    textBox2.Text = Convert.ToString("Числа равны ");
                else
                {
                    int max = n / 10 % 10;
                    if (n / 100 > max) max = n / 100;
                    if (n % 10 > max) max = n % 10;
                    textBox2.Text = Convert.ToString(max);
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
