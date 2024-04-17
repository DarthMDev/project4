using System.Diagnostics;
using CIS3433;

namespace AB_game
{
    public partial class welcome : Form
    {
        GameLogger gameLogger;

        public welcome()
        {
            InitializeComponent();

            // Create an instance of the GameLogger class with the connection string
            gameLogger = new GameLogger($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Scoreboard.mdf;Integrated Security=True;");
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            MakeCode codeMaker = new(this, gameLogger, textBox_Name.Text);
            codeMaker.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BreakCode codeBreaker = new(this, gameLogger, textBox_Name.Text);
            codeBreaker.Show();
            this.Hide();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
