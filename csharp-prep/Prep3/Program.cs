using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();

        int g = int.Parse(guess);

        while (g != magicNumber)
        {
            if (g < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess! ");
            guess = Console.ReadLine();
            g = int.Parse(guess);
        }

        Console.WriteLine("You guessed it!");
    }
}