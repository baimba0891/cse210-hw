using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine();

        Fraction fraction2 = new Fraction(5);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine();

        Fraction fraction3 = new Fraction(3, 4);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine();

        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Console.WriteLine();

        Fraction fraction5 = new Fraction();

        fraction5.SetTop(6);
        fraction5.SetBottom(7);

        Console.WriteLine("Testing Getters and Setters");
        Console.WriteLine($"Top: {fraction5.GetTop()}");
        Console.WriteLine($"Bottom: {fraction5.GetBottom()}");
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
    }
}
