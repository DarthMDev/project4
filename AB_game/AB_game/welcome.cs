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
            string path = Directory.GetCurrentDirectory();
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={path}..\..\..\..\Scoreboard.mdf;Integrated Security=True";

            // Create an instance of the GameLogger class with the updated connection string
            gameLogger = new GameLogger(connectionString);
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            MakeCode codeMaker = new(this);
            codeMaker.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BreakCode codeBreaker = new(this, gameLogger, textBox_Name.Text);
            codeBreaker.Show();
            this.Hide();
            gameLogger.LogGameDetails("Team", "Code Breaker", "2345", DateTime.Now, 3, 10, 10);

        }
    }
}
