namespace OnlinePsychiatrist
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
            this.label1 = new System.Windows.Forms.Label();
            this.problem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reply = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Problem: ";
            // 
            // problem
            // 
            this.problem.Location = new System.Drawing.Point(195, 66);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(468, 20);
            this.problem.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ask Dr Sharp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reply
            // 
            this.reply.AutoSize = true;
            this.reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reply.Location = new System.Drawing.Point(62, 177);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(54, 20);
            this.reply.TabIndex = 3;
            this.reply.Text = "Reply";
            this.reply.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 229);
            this.Controls.Add(this.reply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "The Online Psychiatrist - Dr Sharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reply;
    }
}

