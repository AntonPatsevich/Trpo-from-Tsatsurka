using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public static BigInteger factorial(int n)
        {
            BigInteger ret = 1;
            for (int i = 1; i <= n; ++i) ret *= i;
            return ret;
        }
        private bool ValidateContactAll()
        {
            double i;
            if (double.TryParse(textBox1.Text, out i) && double.TryParse(textBox2.Text, out i))
            {
                return true;
            }
            return false;
        }
        private bool ValidateContact()
        {
            double i;
            return double.TryParse(textBox1.Text, out i);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateContactAll())
            {
                try
                {
                    label1.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidateContactAll())
            {
                try
                {
                    label1.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateContactAll())
            {
                try
                {
                    label1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ValidateContactAll())
            {
                try
                {
                    label1.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateContact())
            {
                try
                {
                    label1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ValidateContactAll())
            {
                try
                {
                    label1.Text = (Math.Pow(double.Parse(textBox1.Text), double.Parse(textBox2.Text))).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ValidateContactAll())
            {
                try
                {
                    label1.Text = (double.Parse(textBox1.Text) % double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ValidateContact())
            {
                try
                {
                    label1.Text = (Math.Log(double.Parse(textBox1.Text))).ToString();
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ValidateContact())
            {
                try
                {
                    label1.Text = (Math.Sin(double.Parse(textBox1.Text))).ToString();
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ValidateContact())
            {
                try
                {
                    label1.Text = (Math.Cos(double.Parse(textBox1.Text))).ToString();
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ValidateContact())
            {
                try
                {
                    label1.Text = (Math.Tan(double.Parse(textBox1.Text))).ToString();
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ValidateContact())
            {
                try
                {
                    label1.Text = (factorial(int.Parse(textBox1.Text))).ToString();
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не те значения", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {

            try
            {
                label1.Text = Math.PI.ToString();
                textBox2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {

            try
            {
                label1.Text = Math.E.ToString();
                textBox2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
