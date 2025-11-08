using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.add(newEntry);

    }

    public void DisplayEntries()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine($"{_entries[i].Display()}");
        }
    }

    public void SavingFiles(string _filename, Entry entries)
    {

        bool enter = true;
        if (string.IsNullOrWhiteSpace(_filename))
        {
            return;
        }
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine(entry.Display());
            }
        }
        
            
    }

    public void LoadFiles(string _loadfilenames)
    {
        _loadfilenames = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_loadfilenames);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}