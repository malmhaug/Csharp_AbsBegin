/*
 Version: 1.00

 Last author: Jim Malmhaug

 Updates:
            ...
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

            //Questions
            if (question1_answer.Text.ToLower() == "round")
            {
                grade = grade + 1;
            }

            if (question2_answer.Text.ToLower() == "money")
            {
                grade = grade + 1;
            }

            if (question3_answer.Text.ToLower() == "harald")
            {
                grade = grade + 1;
            }

            if (question4_answer.Text.ToLower() == "false")
            {
                grade = grade + 1;
            }

            if ((question5_answer.Text == "4") || (question5_answer.Text == "four"))
            {
                grade = grade + 1;
            }

            //Feedback
            if (grade >= 3)
            {
                feedback = "Weel Done!";
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
    }
}
