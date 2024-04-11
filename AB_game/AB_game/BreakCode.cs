using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AB_game
{
    public partial class BreakCode : Form
    {
        private string code;
        private welcome form;
        private List<string> possibleGuesses = GenerateAllPossibleGuesses();
        private List<string> previousGuesses = new List<string>();

        public BreakCode(string code, welcome form)
        {
            InitializeComponent();
            this.code = code;
            this.form = form;
        }

        private void BreakCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hint = textBox_Hint.Text.Trim();
            if (!string.IsNullOrEmpty(hint))
            {
                textBox_Guess.Text = MakeGuess(hint);
            }
            else
            {
                label_Error.Text = "Please provide a hint before making a guess.";
            }
        }

        private string MakeGuess(string hint)
        {
            // Filter out guesses that match the hint
            List<string> filteredGuesses = possibleGuesses.Where(guess => IsConsistentWithHint(guess, hint)).ToList();

            // Avoid making the same guess twice
            filteredGuesses = filteredGuesses.Except(previousGuesses).ToList();

            // Select the next guess
            string nextGuess = filteredGuesses.FirstOrDefault();
            previousGuesses.Add(nextGuess);

            return nextGuess;
        }

        private bool IsConsistentWithHint(string guess, string hint)
        {
            int correctPositionCount = 0;
            int correctDigitCount = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == hint[i])
                    correctPositionCount++;
                else if (hint.Contains(guess[i]))
                    correctDigitCount++;
            }

            return $"{correctPositionCount}A{correctDigitCount}B" == hint;
        }

        private static List<string> GenerateAllPossibleGuesses()
        {
            List<string> guesses = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == i)
                        continue;

                    for (int k = 0; k < 10; k++)
                    {
                        if (k == i || k == j)
                            continue;

                        for (int l = 0; l < 10; l++)
                        {
                            if (l == i || l == j || l == k)
                                continue;

                            guesses.Add($"{i}{j}{k}{l}");
                        }
                    }
                }
            }

            return guesses;
        }

        private void BreakCode_Load(object sender, EventArgs e)
        {
            textBox_Guess.Text = code;
        }
    }
}
