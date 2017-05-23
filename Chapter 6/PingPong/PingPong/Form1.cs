using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        int paddle_x = 0;
        int paddle_y = 255;
        int paddle_width = 35;
        int paddle_height = 20;
        Graphics g;
        int x = 0; //initial x posistion of the ball
        int y = 0; //initial y posistion of the ball
        int dx = 8; //position increment for the ball on the x axis
        int dy = 5; //position increment for the ball on the y axis

        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(MovePaddle);
            this.Paint += new PaintEventHandler(paint1);
            Console.Write("Initialization...");
        }

        private void paint1(Object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //draw the paddle
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            g.FillRectangle(blueBrush, paddle_x, paddle_y, paddle_width, paddle_height);

            //draw the ball
            SolidBrush brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, x, y, 10, 10);
        }

        private void MovePaddle(Object sender, MouseEventArgs e)
        {
            paddle_y = e.Y;
            paddle_x = e.X;
            Invalidate();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            MoveBall();
        }

        private void MoveBall()
        {
            int newBall_x = x + dx;
            int newBall_y = y + dy;

            //Bounce the ball if it has collided with a wall
            if ((newBall_x < 0) || (newBall_x > 300)) dx = -dx;
            if ((newBall_y < 0) || (newBall_y > 255)) dy = -dy;

            //Bounce the ball if it has collided with the paddle
            if (((newBall_x > paddle_x) && (newBall_x < (paddle_x + paddle_width))) && ((newBall_y > paddle_y) && (newBall_y < (paddle_y + paddle_height))))
            {
                if (dx > 0 && dy > 0)
                {
                    dy = -dy;
                }
                if (dx < 0 && dy > 0)
                {
                    dy = -dy;
                }
            }
            x = x + dx;
            y = y + dy;
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
