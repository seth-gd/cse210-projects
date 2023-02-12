using System;

public class Word
{
    // Attributes
    private List<string> _wordList;
    private string _hiddenWord;
    private Random random = new Random();
    private int _allHiddenWords;

    // Getters and Setters
    public List<string> GetWordList()
    {
        return _wordList;
    }

    public void SetWordList(List<string> wordList)
    {
        _wordList = wordList;
    }

    // Methods
    public void HideWord()
    {
        int randomNum = random.Next(0, _wordList.Count);

        for (int i = 0; i < _wordList[randomNum].Length; i++)
        {
            _hiddenWord += "_";
        }

        _wordList[randomNum] = _hiddenWord;
        _hiddenWord = "";
    }

    public bool CheckList()
    {
        _allHiddenWords = 0;

        foreach (string word in _wordList)
        {
            if (word[0] == '_')
            {
                _allHiddenWords++;
            }
        }

        if (_allHiddenWords == _wordList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}