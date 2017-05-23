using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6T1_WalkTheLine
{
    public partial class Form1 : Form
    {
        Point[] points =
        {
            new Point(400,25),
            new Point(100,15),
            new Point(200,70),
            new Point(700,100),
            new Point(900,75)
        };

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Paint_String);
        }

        private void Paint_String(object sender, PaintEventArgs e)
        {
            //create a pen
            Pen pen = new Pen(Color.Blue);
            //draw the path
            e.Graphics.DrawLines(pen, points);
            pen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
