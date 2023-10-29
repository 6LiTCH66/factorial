using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private long calculate_factorial(int number)
        {
            long factorial = 1;
            for (int i = 0; i < number; i++)
            {
                factorial = factorial * (i + 1);
            }

            return factorial;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                if (number < 0)
                {
                    MessageBox.Show("The number have to be nonnegative!");
                    return;
                }

                long factorial = calculate_factorial(number);
                label2.Text = $"The Factorial of number {number} is {factorial}";
            }
            catch
            {
                MessageBox.Show("The input have to be number!");
            }

        }
    }
}
