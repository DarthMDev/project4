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
            textBox_Code = new TextBox();
            label2 = new Label();
            button_Submit = new Button();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 33);
            label1.Name = "label1";
            label1.Size = new Size(414, 62);
            label1.TabIndex = 0;
            label1.Text = "Group 7 Project 4";
            // 
            // textBox_Code
            // 
            textBox_Code.Location = new Point(301, 217);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.Size = new Size(125, 27);
            textBox_Code.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 179);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 2;
            label2.Text = "Please enter code:";
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(370, 269);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(151, 29);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Make Code";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(188, 269);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 4;
            button1.Text = "Break Code";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 118);
            label3.Name = "label3";
            label3.Size = new Size(306, 20);
            label3.TabIndex = 5;
            label3.Text = "Michael Isaacson, Frank Crouch, Michael Gray";
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button_Submit);
            Controls.Add(label2);
            Controls.Add(textBox_Code);
            Controls.Add(label1);
            Name = "welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Code;
        private Label label2;
        private Button button_Submit;
        private Button button1;
        private Label label3;
    }
}
