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

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            //make it to where it shows the context menu strip


        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // this will clear the database
            // are you sure you want to clear the database dialog
            // if yes then clear the database
            // if no then do nothing
            if (MessageBox.Show("Are you sure you want to clear the database? This change cannot be undone and is really dangerous. The data cannot be recovered.", "Clear Database", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gameLogger.ClearDatabase();
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // close the form
           Close();
        }
    }
}
