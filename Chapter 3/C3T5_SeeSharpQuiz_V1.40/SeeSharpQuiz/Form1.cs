/*
 Version: 1.40

 Last author: Jim Malmhaug
 Date: 19 Feb 2017

 Updates:
            + Thumbs up picture
            + Extra feedback
            + With tip
            + Timer
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeeSharpQuiz
{
    public partial class Form1 : Form
    {

        //Initialize variables
        int timeLeft = 30;
        int grade = 0;
        string feedback = "";

        public Form1()
        {
            InitializeComponent();
            timer1.Start(); //Start timer
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grade_button_Click(object sender, EventArgs e)
        {
            //Questions
            if (question1_answer.Text.ToLower() == "round")
            {
                grade = grade + 1;
                feedbackQ1.Visible = false;
            }
            else
            {
                feedbackQ1.Visible = true;
            }

            if (question2_answer.Text.ToLower() == "money")
            {
                grade = grade + 1;
                feedbackQ2.Visible = false;
            }
            else
            {
                feedbackQ2.Visible = true;
            }

            if (question3_answer.Text.ToLower() == "harald")
            {
                grade = grade + 1;
                feedbackQ3.Visible = false;
            }
            else
            {
                feedbackQ3.Visible = true;
            }

            if (question4_answer.Text.ToLower() == "false")
            {
                grade = grade + 1;
                feedbackQ4.Visible = false;
            }
            else
            {
                feedbackQ4.Visible = true;
            }

            if ((question5_answer.Text == "4") || (question5_answer.Text == "four"))
            {
                grade = grade + 1;
                feedbackQ5.Visible = false;
            }
            else
            {
                feedbackQ5.Visible = true;
            }

            //Feedback
            if (grade >= 3)
            {
                feedback = "Well Done!";
                pictureBox1.Visible = true;
                timer1.Stop();
            }
            else
            {
                feedback = "Could do much better!";
            }

            lbl_feedback.Text = grade + "/5. " + feedback;
            lbl_feedback.Visible = true;
        }

        private void lbl_Question1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void question5_answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void feedbackQ5_Click(object sender, EventArgs e)
        {

        }

        private void tipButton1_Click(object sender, EventArgs e)
        {
            tipText1.Visible = true;
            tipText1.Text = "Not flat, but ...";
        }

        private void tipButton2_Click(object sender, EventArgs e)
        {
            tipText2.Visible = true;
            tipText2.Text = "You can buy the whole world with it.";
        }

        private void tipButton3_Click(object sender, EventArgs e)
        {
            tipText3.Visible = true;
            tipText3.Text = "Son of Kong Olav.";
        }

        private void tipButton4_Click(object sender, EventArgs e)
        {
            tipText4.Visible = true;
            tipText4.Text = "Not true, but ...";
        }

        private void tipButton5_Click(object sender, EventArgs e)
        {
            tipText5.Visible = true;
            tipText5.Text = "Above 3 and under 5.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Initialize variable
            timer1.Interval = 1000;

            if (timeLeft > 0)
            {
                //Display time left
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //Execute when time is over
                timer1.Stop();
                timeLabel.Text = "-";
                MessageBox.Show("You didn't finish in time!");
                Application.Exit();  //Close application
            }
        }
    }
}
