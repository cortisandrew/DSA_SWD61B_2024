using GuessingGame;

const int RUNS = 1000;

List<int> workRequired = new List<int>();

for (int i = 0; i < RUNS; i++)
{
    // Create secret number
    var secretNumber = new SecretNumber(100);

    // set up strategy
    GuessingStrategyA strategyA = new GuessingStrategyA(secretNumber);

    // carry out strategy
    (int, int) strategyAResults = strategyA.Guess();

    // summarise the results
    Console.WriteLine($"Using Strategy A, the secret number is {strategyAResults.Item1}. It took {strategyAResults.Item2} guesses to find");
}



// Create 2 algorithms to guess

// Run for different problem sizes and compare the results