using System;
using System.Data.SqlClient;

namespace CIS3433
{
    public class GameLogger
    // this class is responsible for logging game data to a database
    {
        private readonly string connectionString; // connection string to the database
        private int sessionId; // the ID of the current game session

        public GameLogger(string dbConnectionString)
        {
            // constructor that initializes the connection string and sets the session ID to -1
            connectionString = dbConnectionString;
            sessionId = -1;
        }
        /// <summary>
        /// Starts a new game session by inserting a new record into the GameSessions table.
        /// <param name="playerName">The name of the player.</param>
        /// <param name="mode">The game mode (e.g., gamebreaker, gamemaker).</param>
        /// <param name="secretNumber">The secret number for the game session.</param>
        /// 
        /// </summary>
         public void StartNewGameSession(string playerName, string mode, int secretNumber)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO GameSessions (PlayerName, Mode, SecretNumber, StartTime) OUTPUT INSERTED.SessionId VALUES (@PlayerName, @Mode, @SecretNumber, @StartTime)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@Mode", mode);
                    command.Parameters.AddWithValue("@SecretNumber", secretNumber);
                    command.Parameters.AddWithValue("@StartTime", DateTime.Now);

                    connection.Open();
                    sessionId = (int)command.ExecuteScalar();  // Assuming SessionId is an auto-incremented primary key
                }
            }
        }
        /// <summary>
        /// Logs a player's guess and the hint provided by the game .
        /// </summary>
        /// <param name="guessNumber"></param>
        /// <param name="hint"></param>
        public void LogGuess(int guessNumber, string hint)
        {
            if (sessionId == -1)
                throw new InvalidOperationException("Game session has not been started.");

            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Guesses (SessionId, GuessNumber, Hint) VALUES (@SessionId, @GuessNumber, @Hint)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SessionId", sessionId);
                    command.Parameters.AddWithValue("@GuessNumber", guessNumber);
                    command.Parameters.AddWithValue("@Hint", hint);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
       /// <summary>
       /// Calculates the player's score based on the total number of tries and the total time taken to complete the game.
       /// </summary>
       /// <param name="totalTries"></param>
       /// <param name="totalSeconds"></param>
        public void FinalizeGameSession(int totalTries, double totalSeconds)
        {
            if (sessionId == -1)
                throw new InvalidOperationException("Game session has not been started.");

            using (var connection = new SqlConnection(connectionString))
            {
                var score = CalculateScore(totalTries, totalSeconds);
                var query = "UPDATE GameSessions SET EndTime = @EndTime, TotalTries = @TotalTries, TotalSeconds = @TotalSeconds, Score = @Score WHERE SessionId = @SessionId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EndTime", DateTime.Now);
                    command.Parameters.AddWithValue("@TotalTries", totalTries);
                    command.Parameters.AddWithValue("@TotalSeconds", totalSeconds);
                    command.Parameters.AddWithValue("@Score", score);
                    command.Parameters.AddWithValue("@SessionId", sessionId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}