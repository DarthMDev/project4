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
            CodeBreaker codeBreaker = new(textBox_Code.Text, this);
            codeBreaker.Show();
            this.Hide();
        }
    }
}
