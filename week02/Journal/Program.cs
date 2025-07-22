using System;
// <summary>
// Journal Application  
// as Stretch challenge for this program I added another input for location :)
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal App!");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Entries to File");
            Console.WriteLine("4. Load Entries from File");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: \n");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your Answer: ");
                    string entryText = Console.ReadLine();
                    Console.Write("Enter your location (optional): "); // Optional location input
                    string location = Console.ReadLine();   // Optional location input
                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _promptText = prompt,
                        _entryText = entryText,
                        _location = location // Optional location input
                    };
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
        Console.WriteLine("Thank you for using the Journal App!");
        Console.WriteLine("Goodbye!");
    }
}