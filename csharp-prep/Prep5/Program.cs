using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squared, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main()
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        PromptUserBirthYear(out int birthYear);

        int squared = SquareNumber(number);

        DisplayResult(name, squared, birthYear);
    }
}