﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5T3_Christmas
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

        public string Countdown()
        {
            var today = DateTime.Now;
            var year  = DateTime.Now.Year;
            var xmas  = new DateTime(year,12,25);
            var timeLeft = xmas - today;
            return timeLeft.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = " Countdown to Christmas: " + Countdown();
        }
    }
}
