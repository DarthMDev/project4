using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using CIS3433;

namespace AB_game
{
    public partial class BreakCode : Form
    {
        private string currentGuess;
        private bool gameStarted;
        private string playerName;
        private welcome form;
        private GameLogger gameLogger;
        private List<string> possibleNumbers;
        private int guessCount;
        private Stopwatch stopwatch;

        public BreakCode(welcome form,GameLogger gameLogger, string playerName)
        {
            InitializeComponent();
            InitializeGame();
            // Start the game with the first guess
            this.form = form;
            this.gameLogger = gameLogger;
            this.playerName = playerName;
            //currentGuess = "";
            //possibleNumbers = new List<string>();
            gameStarted = false;
            stopwatch = new Stopwatch();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                stopwatch.Start();
            }

            string hint = textBox_Hint.Text;
            int cows = int.Parse(hint.Substring(0, 1));
            int bulls = int.Parse(hint.Substring(2, 1));

            if (cows == 4) // If all cows, prompt the user to enter their score
            {
                // Stop the game and display a dialog box to enter the score
                stopwatch.Stop();
                gameStarted = false;

                // Prompt the user to enter their score
                string input = Microsoft.VisualBasic.Interaction.InputBox("Congratulations! The secret number was " + currentGuess + ". Please enter your score:", "Enter Score", "", -1, -1);

                // Validate and process the input
                double score;
                if (double.TryParse(input, out score))
                {
                    // Log the game details without calculating the score
                    gameLogger.LogGameDetails(playerName, "Code Breaker", currentGuess, DateTime.Now, guessCount, stopwatch.Elapsed.TotalSeconds, score);
                }
                else
                {
                    // Invalid input
                    MessageBox.Show("Invalid score! Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Start a new game
                InitializeGame();
            }
            else
            {
                // Remove impossible numbers based on the hint
                possibleNumbers = possibleNumbers.Where(num =>
                {
                    int numCows = CountCows(num, currentGuess);
                    int numBulls = CountBulls(num, currentGuess);
                    return numCows == cows && numBulls == bulls;
                }).ToList();

                // Move to the next guess
                currentGuess = possibleNumbers.First();
                guessCount++;
                textBox_Guess.Text = currentGuess;
                label_Error.Text = $"Number of possible remaining guesses: {possibleNumbers.Count()}";
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
