/*Version: V1.00

Updates:
    + Countdown timer
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

namespace MathGame
{
    public partial class Form1 : Form
    {
        Random randomNo = new Random();
        int no1;
        int no2;
        string problemType = "+";
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            startGame.Visible = false;
            checkAnswer.Visible = true;
            question.Visible = true;
            Answer.Visible = true;
            nextQuestion.Visible = true;
            feedback.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            Gen_Question();
            timer1.Start();

        }

        private void Gen_Question()
        {
            no1 = randomNo.Next(100);
            no2 = randomNo.Next(100);

            if (radioButton1.Checked)
            {
                problemType = "+";
            }
            else if (radioButton2.Checked)
            {
                problemType = "-";
            }
            else if (radioButton3.Checked)
            {
                problemType = "*";
            }

            question.Text = no1 + problemType + no2 + " = ";

        }

        private void checkAnswer_Click(object sender, EventArgs e)
        {
            int result = 0;

            if (problemType == "+")
            {
                result = no1 + no2;
            }
            else if (problemType == "-")
            {
                result = no1 - no2;
            }
            else if (problemType == "*")
            {
                result = no1 * no2;
            }

            if (Answer.Text == result.ToString())
            {
                feedback.Text = "CORRECT!";
                timeLeft = 30; //restart timer
            }
            else
            {
                feedback.Text = "INCORRECT!";
            }
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            Gen_Question();
            Answer.Text = "";
            feedback.Text = "";
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (timeLeft > 0)
            {
                // Display the new time left
                timeLeft = timeLeft - 1;
                label3.Text = timeLeft + " seconds";
            }
            else
            {
                // Show what happens if timer runs out
                timer1.Stop();
                label3.Text = ":-(";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                startGame.Visible = true;
                checkAnswer.Visible = false;
                question.Visible = false;
                Answer.Visible = false;
                nextQuestion.Visible = false;
                feedback.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}