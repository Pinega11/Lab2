using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textbox1.Text);
            b = Convert.ToInt32(textbox2.Text);
            int comp = 0;
            for (int i = 0; i < a; i++)
            {
                comp += b;
                textbox3.Text = Convert.ToString(+comp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны натуральные числа х и у. Вычислить произведение xy, используя лишь операцию сложения ");
        }

        private void textbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textbox1.Focus();
            }
        }

        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textbox2.Focus();
            }
        }

        private void textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
