using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
class Program
{
    static void Main(string[] args)
    {


        List<int> numbers = new List<int>();
        string value;
        Console.Write("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        double sum = 0;


        do
        {
            Console.Write("Enter Number:");
            value = Console.ReadLine();
            number = int.Parse(value);
            if (number > 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int largest = numbers[0];
        foreach (int numeric in numbers)
        {
            sum += numeric;
            if (numeric > largest)
            {
                largest = numeric;
            }
        }

        double counter = numbers.Count;

        Console.WriteLine($"The sum is: {sum}");

        double average = sum / counter;
        Console.WriteLine($"The average is {average}");

        Console.WriteLine($"The largest number is: {largest}");


    }
}