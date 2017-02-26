using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinePsychiatrist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables
            String ReplyText;
            Random randomNo = new Random();
            int responseType = randomNo.Next(3);

            if (responseType == 0)
            {
                ReplyText = "Tell me more?";
            }
            else if (responseType == 1)
            {
                ReplyText = "Have you always felt this way?";
            }
            else
            {
                ReplyText = problem.Text;
                ReplyText = ReplyText.Replace("I","You");
                ReplyText = ReplyText.Replace(" am ", " are ");
                ReplyText = ReplyText.Replace(" my ", " your ");
            }
            reply.Text = ReplyText;
            reply.Visible = true;
        }
    }
}
