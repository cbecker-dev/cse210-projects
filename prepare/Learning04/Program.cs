using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
    }
}