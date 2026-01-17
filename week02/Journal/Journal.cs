using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string filename = file;
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}");
                outputFile.WriteLine($"{entry._promptText}");
                outputFile.WriteLine($"{entry._entryText}");
                outputFile.WriteLine("");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i += 4)
        {
            Entry entry = new Entry();

            entry._date = lines[i];
            entry._promptText = lines[i + 1];
            entry._entryText = lines[i + 2];

            _entries.Add(entry);
        }
    }
}