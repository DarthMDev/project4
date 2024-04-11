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
            SuspendLayout();
            // 
            // textBox_Guess
            // 
            textBox_Guess.Location = new Point(359, 199);
            textBox_Guess.Name = "textBox_Guess";
            textBox_Guess.Size = new Size(125, 27);
            textBox_Guess.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 163);
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
            button_Submit.Location = new Point(375, 232);
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
            // CodeBreaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label_GuessesRemaining);
            Controls.Add(button_Submit);
            Controls.Add(label_Hint);
            Controls.Add(label1);
            Controls.Add(textBox_Guess);
            Name = "CodeBreaker";
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
    }
}