using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AB_game
{
    public partial class BreakCode : Form
    {
        private string currentGuess;
        private welcome form;
        private List<string> possibleNumbers;
        private int guessCount;

        public BreakCode(string code, welcome form)
        {
            InitializeComponent();
            InitializeGame();
            // Start the game with the first guess
            this.form = form;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hint = textBox_Hint.Text;
            int cows = int.Parse(hint.Substring(0, 1));
            int bulls = int.Parse(hint.Substring(2, 1));

            // Remove impossible numbers based on the hint
            possibleNumbers = possibleNumbers.Where(num =>
            {
                int numCows = CountCows(num, currentGuess);
                int numBulls = CountBulls(num, currentGuess);
                return numCows == cows && numBulls == bulls;
            }).ToList();

            if (cows == 4) // If all cows, the game is won
            {
                label_Error.Text = $"Congratulations! The secret number was {currentGuess}. Guessed in {guessCount} attempts.";
                InitializeGame(); // Start a new game
            }
            else
            {
                // Move to the next guess
                currentGuess = possibleNumbers.First();
                guessCount++;
                textBox_Guess.Text = currentGuess;
            }
        }

        private void InitializeGame()
        {
            possibleNumbers = GeneratePossibleNumbers();
            currentGuess = possibleNumbers.First(); // Start with the first guess
            guessCount = 1;
            textBox_Guess.Text = currentGuess;
        }

        private List<string> GeneratePossibleNumbers()
        {
            return Enumerable.Range(0, 10000)
                .Select(i => i.ToString("D4"))
                .Where(num => num.Distinct().Count() == 4)
                .ToList();
        }

        private int CountCows(string secret, string guess)
        {
            return secret.Where((t, i) => t == guess[i]).Count();
        }

        private int CountBulls(string secret, string guess)
        {
            return guess.Count(t => secret.Contains(t)) - CountCows(secret, guess);
        }

        private void BreakCode_Load(object sender, EventArgs e)
        {
            textBox_Guess.Text = currentGuess;
        }

        private void BreakCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
