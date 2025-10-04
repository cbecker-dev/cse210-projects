using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine("f1: " + f1.GetFractionString());

        Fraction f2 = new Fraction(6);
        Console.WriteLine("f2: " + f2.GetFractionString());

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine("f3: " + f3.GetFractionString());
    }
}
