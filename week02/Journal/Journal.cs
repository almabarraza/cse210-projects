using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
           e.Display();
           Console.WriteLine();
        }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter writeFile = new StreamWriter(file))

        foreach (Entry e in _entries)
            {
                writeFile.WriteLine($"{e._date}~{e._promptText}~{e._entryText}");
            }

    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading from file...");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string l in lines)
        {
            string[] journalParts = l.Split("~");
            string date = journalParts[0];
            string prompt = journalParts[1];
            string entry = journalParts[2];

            Console.WriteLine($"{date} {prompt} {entry}");

        } 
        
    }








}

