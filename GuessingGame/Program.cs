using GuessingGame;

const int RUNS = 200;

List<int> problemSizes = new List<int>() { 100, 500, 10000, 100000, 1000000, 10000000, 100000000 };

Console.WriteLine("Algorithm B:");
foreach (int problemSize in problemSizes)
{
    List<int> workRequired = new List<int>();

    for (int i = 0; i < RUNS; i++)
    {
        // Create secret number
        var secretNumberB = new SecretNumber(problemSize);

        // set up strategy
        GuessingStrategyB strategyB = new GuessingStrategyB(secretNumberB);

        // carry out strategy
        (int, int) strategyBResults = strategyB.Guess();


        // summarise the results
        //Console.WriteLine($"Using Strategy B, the secret number is {strategyBResults.Item1}. It took {strategyBResults.Item2} guesses to find");
        workRequired.Add(strategyBResults.Item2);
    }
    Console.WriteLine($"When the problem size is {problemSize}, the average work was {workRequired.Average()}");
}


Console.WriteLine("Algorithm A:");
foreach (int problemSize in problemSizes)
{
    List<int> workRequired = new List<int>();

    for (int i = 0; i < RUNS; i++)
    {
        // Create secret number
        var secretNumber = new SecretNumber(problemSize);

        // set up strategy
        GuessingStrategyA strategyA = new GuessingStrategyA(secretNumber);

        // carry out strategy
        (int, int) strategyAResults = strategyA.Guess();

        // summarise the results
        // Console.WriteLine($"Using Strategy A, the secret number is {strategyAResults.Item1}. It took {strategyAResults.Item2} guesses to find");
        workRequired.Add(strategyAResults.Item2);
    }

    Console.WriteLine($"When the problem size is {problemSize}, the average work was {workRequired.Average()}");
}

