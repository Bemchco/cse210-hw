public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); // Add a blank line between entries
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Enter the date: {entry._date}");
                writer.WriteLine($"Enter the prompt: {entry._promptText}");
                writer.WriteLine($"Enter the entry: {entry._entryText}\n");
                if (!string.IsNullOrEmpty(entry._location))
                {
                    writer.WriteLine($"Location: {entry._location}");
                }
                else
                {
                    writer.WriteLine("Location: Not specified");
                }
                writer.WriteLine(); // Add a blank line between entries
            }
        }

    }
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 5) // Assuming each entry consists of 4 lines plus a blank line
        {
            if (i + 4 < lines.Length) // Ensure there are enough lines for a complete entry
            {
                Entry entry = new Entry
                {
                    _date = lines[i],
                    _promptText = lines[i + 1],
                    _entryText = lines[i + 2],
                    _location = lines[i + 3]
                };
                _entries.Add(entry);
            }
        }
    }
}
