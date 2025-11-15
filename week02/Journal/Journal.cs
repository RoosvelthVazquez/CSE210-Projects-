using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Member variables
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method (member function)
    public void AddEntry(Entry newentry)
    {
        _entries.Add(newentry); 
    }

    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            i.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry i in _entries)
            {
                writer.WriteLine($"{i._date}|{i._mood}|{i._prompText}|{i._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._mood = parts[1];
            entry._prompText = parts[2];
            entry._entryText = parts[3];

            _entries.Add(entry);
        }

    }
}