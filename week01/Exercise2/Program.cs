using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string letter = "";
        string gradeVal = Console.ReadLine();
        int grade = int.Parse(gradeVal);
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"{letter}");


        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratualions you passed!");
        }
        else
        {
            Console.WriteLine("Keep trying you can do it!");
        }



    }
}