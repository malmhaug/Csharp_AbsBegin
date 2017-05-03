using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5T1_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                circumBox.Text = (Convert.ToDouble(radiusBox.Text) * 2.0 * Math.PI).ToString();
                areaBox.Text = (Convert.ToDouble(radiusBox.Text) * Convert.ToDouble(radiusBox.Text) * Math.PI).ToString();
            }
            catch
            {
                circumBox.Text = "ERROR!";
                areaBox.Text = "ERROR!";
            }
        }
    }
}
