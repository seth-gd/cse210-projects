using System;

public class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private string _fullReference;

    // Constructors
    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _fullReference = $"{_book} {_chapter}:{_verseStart}";
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _fullReference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }

    // Getters and Setters
    public string GetFullReference()
    {
        return _fullReference;
    }
}