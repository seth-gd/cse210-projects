using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        fraction1.SetTop(5);
        fraction1.SetBottom(10);
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}