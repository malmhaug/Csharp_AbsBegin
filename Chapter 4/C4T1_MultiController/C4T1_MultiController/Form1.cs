using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4T1_MultiController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Initialize
            InitializeComponent();
            comboBox.Items.Insert(0,"List Box");
            comboBox.Items.Insert(1, "Group Box");
            comboBox.Items.Insert(2, "Check Box");
            listBox1.Items.Insert(0, "Ape");
            listBox1.Items.Insert(1, "Monkey");
            listBox1.Items.Insert(2, "Gorilla");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
                feedbackBox.Text = "You chose E";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   if (checkBox1.Checked)
                feedbackBox.Text = "You chose D";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedbackBox.Text = "Reset...";
            comboBox.Text = "";
            label3.Visible = false;  //List Box label
            listBox1.Visible = false;
            groupBox.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "List Box")
            {
                feedbackBox.Text = "List Box chosen";
                label3.Visible = true;  //List Box label
                listBox1.Visible = true;
                groupBox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }

            if (comboBox.SelectedItem.ToString() == "Group Box")
            {
                feedbackBox.Text = "Group Box chosen";
                label3.Visible = false;  //List Box label
                listBox1.Visible = false;
                groupBox.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }

            if (comboBox.SelectedItem.ToString() == "Check Box")
            {
                feedbackBox.Text = "Check Box chosen";
                label3.Visible = false;  //List Box label
                listBox1.Visible = false;
                groupBox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Ape")
            {
                feedbackBox.Text = "Ape was selected";
            }

            if (listBox1.SelectedItem.ToString() == "Monkey")
            {
                feedbackBox.Text = "Monkey was selected";
            }

            if (listBox1.SelectedItem.ToString() == "Gorilla")
            {
                feedbackBox.Text = "Gorilla was selected";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            feedbackBox.Text = "You chose A";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            feedbackBox.Text = "You chose B";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            feedbackBox.Text = "You chose C";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                feedbackBox.Text = "You chose F";
        }
    }
}
