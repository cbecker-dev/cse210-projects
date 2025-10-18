using System;

public class Program
{
    public static void Main(string[] args)
    {
        Square mySquare = new Square("Red", 5);

        Console.WriteLine("Color: " + mySquare.GetColor());
        Console.WriteLine("Area: " + mySquare.GetArea());

        Rectangle myRectangle = new Rectangle("Yellow", 3, 4);

        Console.WriteLine("Color: " + myRectangle.GetColor());
        Console.WriteLine("Area: " + myRectangle.GetArea());

        Circle myCircle = new Circle("Blue", 2);

        Console.WriteLine("Color: " + myCircle.GetColor());
        Console.WriteLine("Area: " + myCircle.GetArea());
    }
}