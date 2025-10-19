using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eternal Quest - Simple Test");
        Console.WriteLine("------------------------------\n");

        SimpleGoal goal1 = new SimpleGoal(
            "Run a Marathon",
            "Complete a full marathon race",

            1000
        );

        Console.WriteLine("Before completion:");
        Console.WriteLine(goal1.GetInfor());
        Console.WriteLine($"Is Complete? {goal1.IsComplete()}");
        Console.WriteLine();

        goal1.RecordEvent();
        Console.WriteLine();

        Console.WriteLine("After competion:");
        Console.WriteLine(goal1.GetInfor());
        Console.WriteLine($"Is Complete? {goal1.IsComplete()}");

        Console.WriteLine("\nProgram complete. Press Enter to exit.");
        Console.ReadLine();
    }
}