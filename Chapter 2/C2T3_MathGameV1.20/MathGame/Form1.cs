/*Version: V1.20

Updates:
    + Countdown timer
    + Random question
    + Score
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
        //initialize variables
        Random randomNo = new Random();
        int no1;
        int no2;
        string problemType = "+";
        int timeLeft;
        int randomProblem;
        int score;

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
            //show objects
            startGame.Visible = false;
            checkAnswer.Visible = true;
            question.Visible = true;
            Answer.Visible = true;
            nextQuestion.Visible = true;
            feedback.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            timeLeft = 30; //set time
            Gen_Question(); //start generating questions
            timer1.Start(); //start timer
            score = 0;
            label5.Text = score.ToString(); //score
        }

        private void Gen_Question()
        {
            //create random variables
            no1 = randomNo.Next(100);
            no2 = randomNo.Next(100);
            randomProblem = randomNo.Next(3);

            //Problem types
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
            else if (radioButton4.Checked)
            {
                if (randomProblem == 1)
                {
                    problemType = "+";
                }
                if (randomProblem == 2)
                {
                    problemType = "-";
                }
                if (randomProblem == 0)
                {
                    problemType = "*";
                }
            }

            question.Text = no1 + problemType + no2 + " = ";

        }

        private void checkAnswer_Click(object sender, EventArgs e)
        {
            int result = 0;

            //Check user input
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
                score += 1;
            }
            else
            {
                feedback.Text = "INCORRECT!";
                score -= 1;
            }
            label5.Text = score.ToString(); //score
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
                MessageBox.Show("You didn't finish in time, and your score is " + score, "Sorry!");
                startGame.Visible = true;
                checkAnswer.Visible = false;
                question.Visible = false;
                Answer.Visible = false;
                nextQuestion.Visible = false;
                feedback.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}