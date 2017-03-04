using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4T4_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sumField.Text = "";
        }

        int sum = 0;
        string lastClicked = ""; //The button that was clicked last

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            sum = 0;
            sumField.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumField.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void sumField_TextChanged(object sender, EventArgs e)
        {

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            sumField.Text += "0";
        }

        private void plussButton_Click(object sender, EventArgs e)
        {
            sum += Int32.Parse(sumField.Text);
            sumField.Text = "";
            lastClicked = "+";
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (lastClicked == "+")
            {
                sum += Int32.Parse(sumField.Text);
                sumField.Text = sum.ToString();
            }
        }
    }
}
