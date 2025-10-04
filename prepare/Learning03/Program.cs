using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine("f1 (default): " + f1.GetFractionString());

        Fraction f2 = new Fraction(5);
        Console.WriteLine("f2 (one argument): " + f2.GetFractionString());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine("f3 (two arguments): " + f3.GetFractionString());

        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine();

        Console.WriteLine("f3 Top (getter): " + f3.GetTop());
        Console.WriteLine("f3 Bottom (getter): " + f3.GetBottom());

        f3.SetTop(10);
        f3.SetBottom(20);

        Console.WriteLine("f3 Updated Top (getter): " + f3.GetTop());
        Console.WriteLine("f3 Updated Bottom (getter): " + f3.GetBottom());

        Console.WriteLine("f3 Updated Fraction: " + f3.GetFractionString());
    }


}
