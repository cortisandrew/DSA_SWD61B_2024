namespace GuessingGame
{
    /// <summary>
    /// 
    /// </summary>
    public class GuessingStrategyA
    {
        private SecretNumber SecretNumber;

        /// <summary>
        /// Try to guess all the numbers starting from 1, up to the last number
        /// </summary>
        /// <param name="secret"></param>
        public GuessingStrategyA(SecretNumber secret)
        {
            SecretNumber = secret;
        }

        public (int,int) Guess() {

            for (int i = 1; i < SecretNumber.MaxValue; i++)
            {
                if (SecretNumber.Guess(i) == 0)
                {
                    return (i, SecretNumber.Work);
                }
            }

            SecretNumber.Guess(SecretNumber.MaxValue);
            return (SecretNumber.MaxValue, SecretNumber.Work);
        }
    }
}
