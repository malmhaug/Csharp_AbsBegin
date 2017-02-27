using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4T2_Fahrenheit2Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double fahrenheit = (Double.Parse(celsiusBox.Text) * 1.8) + 32; //Calculate fahrenheit
            fahrenheitBox.Text = fahrenheit.ToString();
        }
    }
}
