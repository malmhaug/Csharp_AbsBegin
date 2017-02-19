/*
 Version: 1.10

 Last author: Jim Malmhaug
 Date: 18 Feb 2017

 Updates:
            + Thumbs up picture
            + Extra feedback
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grade_button_Click(object sender, EventArgs e)
        {
            //Variables
            int grade = 0;
            string feedback = "";
            string wrongAnswer = "";

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
    }
}
