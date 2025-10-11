public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public void displayJournal()
    {
        foreach (Entry i in _journal)
        {
            Console.WriteLine($"Date: {i._date}");
            Console.WriteLine($"Prompt: {i._prompt}");
            Console.WriteLine($"Response: {i._response}\n");
        }
    }
    public void load()
    {
        Console.Write("Enter filename to load your journal: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry e = new Entry();
                e._date = parts[0];
                e._prompt = parts[1];
                e._response = parts[2];
                _journal.Add(e);
            }
        }
    }
    public void save()
    {
        Console.Write("Enter filename to save your journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry i in _journal)
            {
                outputFile.WriteLine($"{i._date}|{i._prompt}|{i._response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }
    public void addEntry(Entry add)
    {
        _journal.Add(add);
    }
}