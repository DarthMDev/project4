using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS3433;

namespace AB_game
{
    public partial class MakeCode : Form
    {
        string code;
        welcome form;
        bool gameStarted = false;
        int guessesRemaining = 10;
        string playerName;
        Stopwatch stopwatch = new Stopwatch();
        GameLogger gameLogger;
        public MakeCode(welcome form, GameLogger gameLogger, string playerName)
        {
            InitializeComponent();

            this.form = form;
            this.gameLogger = gameLogger;
            this.playerName = playerName;
        }

        private void CodeBreaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if(!gameStarted)
            {
                gameStarted = true;
                stopwatch.Start();
            }
            // Initialize variables to count the number of A and B hints
            int A = 0; // Number of digits in the guess that are in the correct position
            int B = 0; // Number of digits in the guess that are in the secret code but in the wrong position

            // Create arrays to track which digits have been matched in the guess and secret code
            bool[] matchedInGuess = new bool[4];
            bool[] matchedInSecret = new bool[4];

            string guess = textBox_Guess.Text;
            string secretCode = this.code;

            // Loop through each digit in the guess
            for (int i = 0; i < guess.Length; i++)
            {
                // If the digit at this position in the guess matches the digit at the same position in the secret code
                if (guess[i] == secretCode[i])
                {
                    // Increment A hint
                    A++;
                    // Mark this digit as matched in both the guess and the secret code
                    matchedInGuess[i] = true;
                    matchedInSecret[i] = true;
                }
            }

            // Loop through each digit in the guess
            for (int i = 0; i < guess.Length; i++)
            {
                // If this digit has already been matched in the guess, skip it
                if (matchedInGuess[i])
                    continue;

                // Loop through each digit in the secret code
                for (int j = 0; j < secretCode.Length; j++)
                {
                    // If this digit has already been matched in the secret code, skip it
                    if (matchedInSecret[j])
                        continue;

                    // If the digit in the guess matches a digit in the secret code but is not in the same position
                    if (guess[i] == secretCode[j])
                    {
                        // Increment B hint
                        B++;
                        // Mark this digit as matched in the guess and the secret code
                        matchedInGuess[i] = true;
                        matchedInSecret[j] = true;
                        break;
                    }
                }
            }

            // Construct and return the hints string
            label_Hint.Text = $"{A}A{B}B";

            if (label_Hint.Text != "4A0B")
            {
                guessesRemaining--;
                label_GuessesRemaining.Text = "Guesses Remaining: " + guessesRemaining.ToString();
            }
            else
            {
                stopwatch.Stop();
                double score = ScoreCalculator.CalculateScore(11-guessesRemaining, stopwatch.Elapsed.TotalSeconds);
                gameLogger.LogGameDetails(playerName, "Code Maker", code, DateTime.Now, 11-guessesRemaining, stopwatch.Elapsed.TotalSeconds, score);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.code = textBox_Code.Text;
            button_Submit.Enabled = true;
        }
    }
}