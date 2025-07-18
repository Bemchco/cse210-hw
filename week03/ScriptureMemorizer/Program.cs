using System;
using System.Runtime.InteropServices;

// Scripture Memorizer
// This program is a simple scripture memorization tool that allows users to hide random words from a given scripture text.
// Users can repeatedly hide words and even though they are random words, the same words will not be hidden and thus every time they hit enter a new set of words will hide until all words are hidden or they choose to exit.
class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("John", 3, 16);
        Scripture _scripture = new Scripture(_reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.Clear();
        Console.WriteLine($"Reference: {_reference.GetReference()}");
        Console.WriteLine(_scripture.GetFullText());
        Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit.");
        string _input = Console.ReadLine();
        if (_input.ToLower() == "quit" || _scripture.IsCompletelyHidden())
            Console.WriteLine("Thank you for using Scripture Memorizer!");
        else
        {
            _scripture.HideRandomWords(3);
        }

        while (_input.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine($"Reference: {_reference.GetReference()}");
            Console.WriteLine(_scripture.GetFullText());
            Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit.");
            _input = Console.ReadLine();
            if (_input.ToLower() == "quit" || _scripture.IsCompletelyHidden())
                break;

            _scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine("Either you typed quit, or all the words are hidden. \nThank you for using Scripture Memorizer!\n");

    }
}