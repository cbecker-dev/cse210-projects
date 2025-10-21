using System;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        foreach (var e in _entries)
        {
            Console.WriteLine(e.ToString());
        }
    }
    public void SaveToFile(string fileName)
    {
        using (var writer = new StreamWriter(fileName))
        {
            foreach (var e in _entries)
            {
                writer.WriteLine(e.ToStorageString());
            }
        }
        Console.WriteLine("Journal saved.\n");
    }

    public void LoadFromFile(string fileName)
    {
        var fresh = new List<Entry>();
        using (var reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var e = Entry.FromstorageString(line);
                if (e != null) fresh.Add(e);
            }
        }
        _entries = fresh;
        Console.WriteLine("Journal loaded.\n");      
    }
}