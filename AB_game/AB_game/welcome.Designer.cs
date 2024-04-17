namespace AB_game
{
    partial class welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_Submit = new Button();
            button1 = new Button();
            label3 = new Label();
            textBox_Name = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 27);
            label1.Name = "label1";
            label1.Size = new Size(600, 90);
            label1.TabIndex = 0;
            label1.Text = "Group 7 Project 4";
            // 
            // button_Submit
            // 
            button_Submit.BackColor = Color.FromArgb(255, 128, 255);
            button_Submit.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Submit.Location = new Point(456, 241);
            button_Submit.Margin = new Padding(3, 2, 3, 2);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(166, 55);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Make a Code";
            button_Submit.UseVisualStyleBackColor = false;
            button_Submit.Click += button_Submit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(213, 241);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(166, 55);
            button1.TabIndex = 4;
            button1.Text = "Break a Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 117);
            label3.Name = "label3";
            label3.Size = new Size(423, 30);
            label3.TabIndex = 5;
            label3.Text = "Michael Isaacson, Frank Crouch, Michael Gray";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(348, 192);
            textBox_Name.Margin = new Padding(3, 2, 3, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(144, 23);
            textBox_Name.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(348, 160);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 8;
            label4.Text = "Name:";
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(836, 441);
            Controls.Add(label4);
            Controls.Add(textBox_Name);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button_Submit);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Submit;
        private Button button1;
        private Label label3;
        private TextBox textBox_Name;
        private Label label4;
    }
}
