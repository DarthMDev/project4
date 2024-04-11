namespace AB_game
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            MakeCode codeMaker = new(textBox_Code.Text, this);
            codeMaker.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BreakCode codeBreaker = new(textBox_Code.Text, this);
            codeBreaker.Show();
            this.Hide();
        }
    }
}
