namespace AB_game
{
    partial class MakeCode
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
            label1 = new Label();
            label_Hint = new Label();
            button_Submit = new Button();
            label_GuessesRemaining = new Label();
            textBox_Code = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox_Guess
            // 
            textBox_Guess.Location = new Point(359, 199);
            textBox_Guess.Name = "textBox_Guess";
            textBox_Guess.Size = new Size(125, 27);
            textBox_Guess.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 176);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 1;
            label1.Text = "Please enter your guess:";
            // 
            // label_Hint
            // 
            label_Hint.AutoSize = true;
            label_Hint.Location = new Point(526, 199);
            label_Hint.Name = "label_Hint";
            label_Hint.Size = new Size(0, 20);
            label_Hint.TabIndex = 2;
            // 
            // button_Submit
            // 
            button_Submit.Enabled = false;
            button_Submit.Location = new Point(375, 241);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(94, 29);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Submit";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // label_GuessesRemaining
            // 
            label_GuessesRemaining.AutoSize = true;
            label_GuessesRemaining.Location = new Point(24, 404);
            label_GuessesRemaining.Name = "label_GuessesRemaining";
            label_GuessesRemaining.Size = new Size(159, 20);
            label_GuessesRemaining.TabIndex = 4;
            label_GuessesRemaining.Text = "Guesses Remaining: 10";
            // 
            // textBox_Code
            // 
            textBox_Code.Location = new Point(359, 62);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.Size = new Size(125, 27);
            textBox_Code.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 39);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 6;
            label2.Text = "Code to break:";
            // 
            // button1
            // 
            button1.Location = new Point(505, 62);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MakeCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox_Code);
            Controls.Add(label_GuessesRemaining);
            Controls.Add(button_Submit);
            Controls.Add(label_Hint);
            Controls.Add(label1);
            Controls.Add(textBox_Guess);
            Name = "MakeCode";
            Text = "CodeBreaker";
            FormClosed += CodeBreaker_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Guess;
        private Label label1;
        private Label label_Hint;
        private Button button_Submit;
        private Label label_GuessesRemaining;
        private TextBox textBox_Code;
        private Label label2;
        private Button button1;
    }
}