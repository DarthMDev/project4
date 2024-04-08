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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 56);
            label1.Name = "label1";
            label1.Size = new Size(414, 62);
            label1.TabIndex = 0;
            label1.Text = "Group 7 Project 4";
            // 
            // textBox_Code
            // 
            textBox_Code.Location = new Point(350, 240);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.Size = new Size(125, 27);
            textBox_Code.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 205);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 2;
            label2.Text = "Please enter code to break:";
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(339, 273);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(151, 29);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Confirm Code";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
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
    }
}
