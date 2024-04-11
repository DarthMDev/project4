namespace AB_game
{
    partial class BreakCode
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
            textBox_Guess = new TextBox();
            textBox_Hint = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label_Error = new Label();
            SuspendLayout();
            // 
            // textBox_Guess
            // 
            textBox_Guess.Location = new Point(219, 157);
            textBox_Guess.Name = "textBox_Guess";
            textBox_Guess.Size = new Size(125, 27);
            textBox_Guess.TabIndex = 0;
            // 
            // textBox_Hint
            // 
            textBox_Hint.Location = new Point(457, 157);
            textBox_Hint.Name = "textBox_Hint";
            textBox_Hint.Size = new Size(125, 27);
            textBox_Hint.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 130);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "Hint";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 130);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Guess";
            // 
            // button1
            // 
            button1.Location = new Point(350, 221);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Next Guess";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_Error
            // 
            label_Error.AutoSize = true;
            label_Error.Location = new Point(344, 271);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(0, 20);
            label_Error.TabIndex = 6;
            // 
            // BreakCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Error);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Hint);
            Controls.Add(textBox_Guess);
            Name = "BreakCode";
            Text = "BreakCode";
            FormClosed += BreakCode_FormClosed;
            Load += BreakCode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Guess;
        private TextBox textBox_Hint;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label_Error;
    }
}