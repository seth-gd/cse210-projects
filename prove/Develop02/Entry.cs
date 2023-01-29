using System;

public class Entry 
{
    DateTime _date = DateTime.Now;

    public string CreateEntry(string givenPrompt) 
    {
        // Create a string holding the date.
        string dateText = _date.ToShortDateString();

        // Ask the user to write the entry.
        Console.WriteLine(givenPrompt);
        Console.Write("> ");
        string inputEntry = Console.ReadLine();

        // Return a string with the date, prompt, and entry.
        return $"Date: {dateText} — Prompt: {givenPrompt}{Environment.NewLine}{inputEntry}{Environment.NewLine}"; 
    }
}