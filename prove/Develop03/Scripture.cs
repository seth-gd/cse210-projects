using System;

public class Scripture
{
    // Attributes
    private string _reference;
    private string _scriptureText;
    private List<string> _scriptureList;

    // Constructors
    public Scripture()
    {
        _reference = "";
        _scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        ScriptureTextToList();
    }

    public Scripture(string reference, string scriptureText)
    {
        _reference = reference;
        _scriptureText = scriptureText;

        ScriptureTextToList();
    }

    // Getters and Setters
    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public List<string> GetScriptureList()
    {
        return _scriptureList;
    }

    public void SetScriptureList(List<string> scriptureList)
    {
        _scriptureList = scriptureList;
    }

    // Methods
    private void ScriptureTextToList()
    {
        string[] splitString = _scriptureText.Split(' ');
        _scriptureList = splitString.ToList();
    }

    public void DisplayFullScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_reference} — " + String.Join(" ", _scriptureList));
    }
}