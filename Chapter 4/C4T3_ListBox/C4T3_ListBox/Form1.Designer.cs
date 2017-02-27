namespace C4T3_ListBox
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.reorderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(181, 147);
            this.listBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(199, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(280, 26);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(100, 20);
            this.addBox.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(199, 64);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 46);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // reorderButton
            // 
            this.reorderButton.Location = new System.Drawing.Point(199, 116);
            this.reorderButton.Name = "reorderButton";
            this.reorderButton.Size = new System.Drawing.Size(75, 46);
            this.reorderButton.TabIndex = 4;
            this.reorderButton.Text = "Sort";
            this.reorderButton.UseVisualStyleBackColor = true;
            this.reorderButton.Click += new System.EventHandler(this.reorderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 182);
            this.Controls.Add(this.reorderButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "List Box Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button reorderButton;
    }
}

