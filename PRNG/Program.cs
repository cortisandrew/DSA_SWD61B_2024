// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random r = new Random();

// returns a uniformly distributed random number between some min and some large max
r.Next();

int min = 1; // inclusive
int max = 6; // exclusive
// max - min = 6
for (int i = 0; i < 100; i++)
{
    int random = r.Next(); // random is positive, therefore integer division (%) and mod give us the same result

    // random % (max - min) // returns a number between 0 and 5

    // Naive method - can lead to a bias, where 1 of the outputs is less likely than the other outputs, EVEN if the original RNG is unbiased.
    Console.WriteLine(
        (random % (max - min)) + min
    );
}

for (int i = 0; i < 100; i++)
{
    int random = r.Next(); // random is positive, therefore integer division (%) and mod give us the same result

    int range = max - min;

    // Method recommended in The Art of Computer Science - if the PRNG is unbiased, you don't introduce any bias
    // int.MaxValue is used because the random numbers are between 0 and int.MaxValue - 1 (i.e. m = int.MaxValue)
    Console.WriteLine(
        (int)Math.Floor((double)(((long)random * (long)range) / int.MaxValue) + min)
    );
}

Console.WriteLine(
    r.Next(1, 7));


// -5 Mod 6 = 1
// Integer remainder gives and incorrect result if used as a modulus operator!
Console.WriteLine(-5 % 6);
