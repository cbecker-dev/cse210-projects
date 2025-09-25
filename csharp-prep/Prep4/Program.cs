using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        int count = 0;
        int max = int.MinValue;

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                break;
            }

            sum += number;
            count += 1;

            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"The average is: {average}");
        }

        Console.WriteLine($"The largest number is: {max}");
    }
    
}