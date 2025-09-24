using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int percentage = int.Parse(valueFromUser);

        string letterGrade;

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (!(letterGrade == "D" || letterGrade == "F"))
        {
            Console.WriteLine("Congratulations you have passed the class!");
        }
        else
        {
            Console.WriteLine("Too bad, better luck next time.");
        }
    }
}