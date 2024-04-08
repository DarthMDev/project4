using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class CodeBreaker : Form
    {
        string code;
        welcome form;

        public CodeBreaker(string code, welcome form)
        {
            InitializeComponent();

            this.code = code;
            this.form = form;
        }

        private void CodeBreaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
