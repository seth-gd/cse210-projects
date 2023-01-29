using System;
using System.IO; 

public class Journal
{
    public List<string> _allEntries = new List<string>();

    public void LoadFile()
    {
        // Grab the file name.
        Console.WriteLine("What is the file name?");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        // Grab each line from the file.
        string[] fileLines = System.IO.File.ReadAllLines(fileName);

        // Add each line to the list of entries.
        foreach (string line in fileLines)
        {
            _allEntries.Add(line);
        }
    }

    public void SaveFile()
    {
        // Grab the file name.
        Console.WriteLine("What is the file name?");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        // Write each entry in the file.
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in _allEntries)
            {
                outputFile.WriteLine(line);
            }
        }
    }
}