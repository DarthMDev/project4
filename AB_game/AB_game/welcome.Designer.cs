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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button_Submit = new Button();
            button1 = new Button();
            label3 = new Label();
            textBox_Name = new TextBox();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            makeCodeToolStripMenuItem = new ToolStripMenuItem();
            breakCodeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            clearDatabaseToolStripMenuItem = new ToolStripMenuItem();
            clearDatabaseToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 74);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(1493, 223);
            label1.TabIndex = 0;
            label1.Text = "Group 7 Project 4";
            // 
            // button_Submit
            // 
            button_Submit.BackColor = Color.FromArgb(255, 128, 255);
            button_Submit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Submit.Location = new Point(1107, 658);
            button_Submit.Margin = new Padding(6);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(404, 164);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Make a Code";
            button_Submit.UseVisualStyleBackColor = false;
            button_Submit.Click += button_Submit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(516, 658);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(404, 164);
            button1.TabIndex = 4;
            button1.Text = "Break a Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 320);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(1086, 71);
            label3.TabIndex = 5;
            label3.Text = "Michael Isaacson, Frank Crouch, Michael Gray";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(846, 525);
            textBox_Name.Margin = new Padding(6);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(344, 47);
            textBox_Name.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(846, 437);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 71);
            label4.TabIndex = 8;
            label4.Text = "Name:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { makeCodeToolStripMenuItem, breakCodeToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(249, 148);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // makeCodeToolStripMenuItem
            // 
            makeCodeToolStripMenuItem.Name = "makeCodeToolStripMenuItem";
            makeCodeToolStripMenuItem.Size = new Size(248, 48);
            makeCodeToolStripMenuItem.Text = "Make Code";
            makeCodeToolStripMenuItem.Click += button_Submit_Click;
            // 
            // breakCodeToolStripMenuItem
            // 
            breakCodeToolStripMenuItem.Name = "breakCodeToolStripMenuItem";
            breakCodeToolStripMenuItem.Size = new Size(248, 48);
            breakCodeToolStripMenuItem.Text = "Break Code";
            breakCodeToolStripMenuItem.Click += button1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(248, 48);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clearDatabaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2029, 52);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // clearDatabaseToolStripMenuItem
            // 
            clearDatabaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearDatabaseToolStripMenuItem1, exitToolStripMenuItem1 });
            clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            clearDatabaseToolStripMenuItem.Size = new Size(87, 48);
            clearDatabaseToolStripMenuItem.Text = "File";
            clearDatabaseToolStripMenuItem.Click += clearDatabaseToolStripMenuItem_Click;
            // 
            // clearDatabaseToolStripMenuItem1
            // 
            clearDatabaseToolStripMenuItem1.Name = "clearDatabaseToolStripMenuItem1";
            clearDatabaseToolStripMenuItem1.Size = new Size(448, 54);
            clearDatabaseToolStripMenuItem1.Text = "Clear Database";
            clearDatabaseToolStripMenuItem1.Click += clearDatabaseToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(448, 54);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2029, 1205);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(textBox_Name);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button_Submit);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "welcome";
            Text = "Welcome";
            Load += welcome_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem makeCodeToolStripMenuItem;
        private ToolStripMenuItem breakCodeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private ToolStripMenuItem clearDatabaseToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
