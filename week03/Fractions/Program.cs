using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetNumbers());
        Console.WriteLine(fraction1.ToDecimal());
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetNumbers());
        Console.WriteLine(fraction2.ToDecimal());
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetNumbers());
        Console.WriteLine(fraction3.ToDecimal());
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetNumbers());
        Console.WriteLine(fraction4.ToDecimal());
    }
}