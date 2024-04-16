namespace CIS3433
{
    public class ScoreCalculator
    {
       
        public static double CalculateScore(int totalTries, double totalSeconds)
        {

            // Calculate the base score by starting with 10, subtracting the total number of tries,
            // adding 1 to the result, and then multiplying by 10.
            // This calculation rewards fewer tries with a higher score.
            int baseScore = 10 * (10 - totalTries + 1);

            // Calculate the time penalty by dividing the total seconds taken by 10.
            // This reduces the score based on how long the player took to complete the game.
            double timePenalty = totalSeconds / 10;

            // Calculate the final score by subtracting the time penalty from the base score.
            // A higher time penalty results in a lower final score.
            double score = baseScore - timePenalty;

            // return the final score
            return score;
        }
    }

}