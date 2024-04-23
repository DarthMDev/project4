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
            listBox_GuessHistory = new ListBox();
            SuspendLayout();
            // 
            // textBox_Guess
            // 
            textBox_Guess.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Guess.Location = new Point(445, 124);
            textBox_Guess.Margin = new Padding(3, 2, 3, 2);
            textBox_Guess.MaxLength = 4;
            textBox_Guess.Name = "textBox_Guess";
            textBox_Guess.Size = new Size(155, 39);
            textBox_Guess.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 84);
            label1.Name = "label1";
            label1.Size = new Size(274, 27);
            label1.TabIndex = 1;
            label1.Text = "Please enter your guess:";
            // 
            // label_Hint
            // 
            label_Hint.AutoSize = true;
            label_Hint.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Hint.Location = new Point(50, 260);
            label_Hint.Name = "label_Hint";
            label_Hint.Size = new Size(0, 27);
            label_Hint.TabIndex = 2;
            // 
            // button_Submit
            // 
            button_Submit.Enabled = false;
            button_Submit.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Submit.Location = new Point(474, 168);
            button_Submit.Margin = new Padding(3, 2, 3, 2);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(103, 45);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Submit";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // label_GuessesRemaining
            // 
            label_GuessesRemaining.AutoSize = true;
            label_GuessesRemaining.Location = new Point(257, 305);
            label_GuessesRemaining.Name = "label_GuessesRemaining";
            label_GuessesRemaining.Size = new Size(127, 15);
            label_GuessesRemaining.TabIndex = 4;
            label_GuessesRemaining.Text = "Guesses Remaining: 10";
            // 
            // textBox_Code
            // 
            textBox_Code.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Code.Location = new Point(38, 124);
            textBox_Code.Margin = new Padding(3, 2, 3, 2);
            textBox_Code.MaxLength = 4;
            textBox_Code.Name = "textBox_Code";
            textBox_Code.PasswordChar = '●';
            textBox_Code.Size = new Size(155, 39);
            textBox_Code.TabIndex = 0;
            textBox_Code.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(167, 27);
            label2.TabIndex = 6;
            label2.Text = "Code to break:";
            // 
            // button1
            // 
            button1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 168);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox_GuessHistory
            // 
            listBox_GuessHistory.FormattingEnabled = true;
            listBox_GuessHistory.ItemHeight = 15;
            listBox_GuessHistory.Location = new Point(224, 98);
            listBox_GuessHistory.Name = "listBox_GuessHistory";
            listBox_GuessHistory.Size = new Size(165, 139);
            listBox_GuessHistory.TabIndex = 7;
            // 
            // MakeCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(listBox_GuessHistory);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox_Code);
            Controls.Add(label_GuessesRemaining);
            Controls.Add(button_Submit);
            Controls.Add(label_Hint);
            Controls.Add(label1);
            Controls.Add(textBox_Guess);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MakeCode";
            Text = "Code Maker";
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
        private ListBox listBox_GuessHistory;
    }
}