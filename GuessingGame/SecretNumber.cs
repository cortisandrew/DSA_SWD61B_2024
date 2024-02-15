namespace GuessingGame
{
    public class SecretNumber
    {
        // only instantiate ONE random number generator!
        private static Random r = new Random();

        // Work is the Number of guesses made so far
        private int work = 0;

        // The largest value that can be stored
        private int n;

        /// <summary>
        /// Return the total amount of guesses made
        /// </summary>
        public int Work
        {
            get { return work; }
        }

        /// <summary>
        /// Get the maximum secret number
        /// </summary>
        public int MaxValue { get { return n; } }

        private int secretNumber;

        /// <summary>
        /// Generate a secret number between 1 and the problem size (both inclusive)
        /// The user will have to write an algorithm to guess the secret number
        /// </summary>
        /// <param name="n">n is the problem size (default 100).</param>
        public SecretNumber(int n = 100)
        {
            this.n = n;

            // generate a secret number between 1 and n (both inclusive)
            this.secretNumber = r.Next(1, n+1);
        }

        /// <summary>
        /// Make a guess. Each guess takes 1 work
        /// </summary>
        /// <param name="guess">The guess by the user</param>
        /// <returns>0 if the guess is equal to the secret number
        /// -1 if the guess is too small
        /// 1 if the guess is too large</returns>
        public int Guess(int guess)
        {
            work++;
            return guess.CompareTo(this.secretNumber);
        }
    }
}
