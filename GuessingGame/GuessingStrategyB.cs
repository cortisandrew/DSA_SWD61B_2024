using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class GuessingStrategyB
    {
        private SecretNumber SecretNumber;

        /// <summary>
        /// Try to guess all the numbers starting from 1, up to the last number
        /// </summary>
        /// <param name="secret"></param>
        public GuessingStrategyB(SecretNumber secret)
        {
            SecretNumber = secret;
        }

        public (int, int) Guess()
        {
            int minValue = 1;
            int maxValue = SecretNumber.MaxValue;
            int guess;

            while (true)
            {

                guess = (minValue + maxValue) / 2;

                int comparisonResult = SecretNumber.Guess(guess);

                if (comparisonResult == 0)
                {
                    return (guess, SecretNumber.Work);
                }
                else if (comparisonResult > 0)
                {
                    // my guess is too large
                    maxValue = guess - 1;
                } else // (comparisonResult < 0)
                {
                    // my guess was too small
                    minValue = guess + 1;
                }
            }
        }
    }
}
