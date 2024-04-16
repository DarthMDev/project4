using System;
using Microsoft.Data.SqlClient;

namespace CIS3433
{
    public class GameLogger
    {
        private string connectionString;

        // Constructor that takes a connection string as input
        public GameLogger(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method to insert values into the GameDetails table
        public void LogGameDetails(string playerName, string playMode, string secretNumber, DateTime dateTime, int tries, double secondsTaken, double gameScore)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to insert values into the GameDetails table
                string query = "INSERT INTO GameDetails (PlayerName, PlayMode, SecretNumber, DateTime, Tries, SecondsTaken, GameScore) " +
                               "VALUES (@PlayerName, @PlayMode, @SecretNumber, @DateTime, @Tries, @SecondsTaken, @GameScore)";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SqlCommand to prevent SQL injection
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@PlayMode", playMode);
                    command.Parameters.AddWithValue("@SecretNumber", secretNumber);
                    command.Parameters.AddWithValue("@DateTime", dateTime);
                    command.Parameters.AddWithValue("@Tries", tries);
                    command.Parameters.AddWithValue("@SecondsTaken", secondsTaken);
                    command.Parameters.AddWithValue("@GameScore", gameScore);

                    // Open the connection
                    connection.Open();

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
