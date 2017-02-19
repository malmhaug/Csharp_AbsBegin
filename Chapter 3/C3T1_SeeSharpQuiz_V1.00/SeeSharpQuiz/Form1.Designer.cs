namespace SeeSharpQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Question1 = new System.Windows.Forms.Label();
            this.lbl_Question2 = new System.Windows.Forms.Label();
            this.lbl_Question3 = new System.Windows.Forms.Label();
            this.lbl_Question4 = new System.Windows.Forms.Label();
            this.lbl_Question5 = new System.Windows.Forms.Label();
            this.question1_answer = new System.Windows.Forms.TextBox();
            this.question2_answer = new System.Windows.Forms.TextBox();
            this.question3_answer = new System.Windows.Forms.TextBox();
            this.question4_answer = new System.Windows.Forms.TextBox();
            this.question5_answer = new System.Windows.Forms.TextBox();
            this.grade_button = new System.Windows.Forms.Button();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Question1
            // 
            this.lbl_Question1.AutoSize = true;
            this.lbl_Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question1.Location = new System.Drawing.Point(12, 9);
            this.lbl_Question1.Name = "lbl_Question1";
            this.lbl_Question1.Size = new System.Drawing.Size(225, 24);
            this.lbl_Question1.TabIndex = 0;
            this.lbl_Question1.Text = "Question 1: The earth is...";
            this.lbl_Question1.Click += new System.EventHandler(this.lbl_Question1_Click);
            // 
            // lbl_Question2
            // 
            this.lbl_Question2.AutoSize = true;
            this.lbl_Question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question2.Location = new System.Drawing.Point(12, 101);
            this.lbl_Question2.Name = "lbl_Question2";
            this.lbl_Question2.Size = new System.Drawing.Size(228, 24);
            this.lbl_Question2.TabIndex = 1;
            this.lbl_Question2.Text = "Question 2: What is NOK?";
            // 
            // lbl_Question3
            // 
            this.lbl_Question3.AutoSize = true;
            this.lbl_Question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question3.Location = new System.Drawing.Point(12, 193);
            this.lbl_Question3.Name = "lbl_Question3";
            this.lbl_Question3.Size = new System.Drawing.Size(342, 24);
            this.lbl_Question3.TabIndex = 2;
            this.lbl_Question3.Text = "Question 3: Who is the King of Norway?";
            // 
            // lbl_Question4
            // 
            this.lbl_Question4.AutoSize = true;
            this.lbl_Question4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question4.Location = new System.Drawing.Point(12, 285);
            this.lbl_Question4.Name = "lbl_Question4";
            this.lbl_Question4.Size = new System.Drawing.Size(316, 24);
            this.lbl_Question4.TabIndex = 3;
            this.lbl_Question4.Text = "Question 4: What is King == Queen?";
            // 
            // lbl_Question5
            // 
            this.lbl_Question5.AutoSize = true;
            this.lbl_Question5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question5.Location = new System.Drawing.Point(12, 377);
            this.lbl_Question5.Name = "lbl_Question5";
            this.lbl_Question5.Size = new System.Drawing.Size(380, 24);
            this.lbl_Question5.TabIndex = 4;
            this.lbl_Question5.Text = "Question 5: What is the integer return of 9/2?";
            // 
            // question1_answer
            // 
            this.question1_answer.Location = new System.Drawing.Point(16, 36);
            this.question1_answer.Name = "question1_answer";
            this.question1_answer.Size = new System.Drawing.Size(100, 20);
            this.question1_answer.TabIndex = 5;
            // 
            // question2_answer
            // 
            this.question2_answer.Location = new System.Drawing.Point(16, 128);
            this.question2_answer.Name = "question2_answer";
            this.question2_answer.Size = new System.Drawing.Size(100, 20);
            this.question2_answer.TabIndex = 6;
            // 
            // question3_answer
            // 
            this.question3_answer.Location = new System.Drawing.Point(16, 220);
            this.question3_answer.Name = "question3_answer";
            this.question3_answer.Size = new System.Drawing.Size(100, 20);
            this.question3_answer.TabIndex = 7;
            // 
            // question4_answer
            // 
            this.question4_answer.Location = new System.Drawing.Point(16, 312);
            this.question4_answer.Name = "question4_answer";
            this.question4_answer.Size = new System.Drawing.Size(100, 20);
            this.question4_answer.TabIndex = 8;
            // 
            // question5_answer
            // 
            this.question5_answer.Location = new System.Drawing.Point(16, 404);
            this.question5_answer.Name = "question5_answer";
            this.question5_answer.Size = new System.Drawing.Size(100, 20);
            this.question5_answer.TabIndex = 9;
            // 
            // grade_button
            // 
            this.grade_button.Location = new System.Drawing.Point(12, 496);
            this.grade_button.Name = "grade_button";
            this.grade_button.Size = new System.Drawing.Size(75, 23);
            this.grade_button.TabIndex = 10;
            this.grade_button.Text = "Grade Quiz";
            this.grade_button.UseVisualStyleBackColor = true;
            this.grade_button.Click += new System.EventHandler(this.grade_button_Click);
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Location = new System.Drawing.Point(13, 526);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(63, 13);
            this.lbl_feedback.TabIndex = 12;
            this.lbl_feedback.Text = "FEEDBACK";
            this.lbl_feedback.Visible = false;
            this.lbl_feedback.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 580);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.grade_button);
            this.Controls.Add(this.question5_answer);
            this.Controls.Add(this.question4_answer);
            this.Controls.Add(this.question3_answer);
            this.Controls.Add(this.question2_answer);
            this.Controls.Add(this.question1_answer);
            this.Controls.Add(this.lbl_Question5);
            this.Controls.Add(this.lbl_Question4);
            this.Controls.Add(this.lbl_Question3);
            this.Controls.Add(this.lbl_Question2);
            this.Controls.Add(this.lbl_Question1);
            this.Name = "Form1";
            this.Text = "SeeSharpQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question1;
        private System.Windows.Forms.Label lbl_Question2;
        private System.Windows.Forms.Label lbl_Question3;
        private System.Windows.Forms.Label lbl_Question4;
        private System.Windows.Forms.Label lbl_Question5;
        private System.Windows.Forms.TextBox question1_answer;
        private System.Windows.Forms.TextBox question2_answer;
        private System.Windows.Forms.TextBox question3_answer;
        private System.Windows.Forms.TextBox question4_answer;
        private System.Windows.Forms.TextBox question5_answer;
        private System.Windows.Forms.Button grade_button;
        private System.Windows.Forms.Label lbl_feedback;
    }
}

