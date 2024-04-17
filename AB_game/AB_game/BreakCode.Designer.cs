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
            textBox_Guess.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Guess.Location = new Point(125, 96);
            textBox_Guess.Margin = new Padding(3, 2, 3, 2);
            textBox_Guess.Name = "textBox_Guess";
            textBox_Guess.Size = new Size(142, 39);
            textBox_Guess.TabIndex = 0;
            // 
            // textBox_Hint
            // 
            textBox_Hint.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Hint.Location = new Point(125, 225);
            textBox_Hint.Margin = new Padding(3, 2, 3, 2);
            textBox_Hint.Name = "textBox_Hint";
            textBox_Hint.Size = new Size(142, 39);
            textBox_Hint.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 191);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 2;
            label1.Text = "Hint";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 62);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 3;
            label2.Text = "Guess";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(417, 138);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(163, 58);
            button1.TabIndex = 4;
            button1.Text = "Next Guess";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_Error
            // 
            label_Error.AutoSize = true;
            label_Error.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Error.Location = new Point(23, 261);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(0, 21);
            label_Error.TabIndex = 6;
            // 
            // BreakCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(label_Error);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Hint);
            Controls.Add(textBox_Guess);
            Margin = new Padding(3, 2, 3, 2);
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