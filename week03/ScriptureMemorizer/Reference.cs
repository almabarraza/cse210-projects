using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = 0;
    }

    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startverse;
        _endverse = endverse;

    }

    public string GetDisplayText()
    {   
        string reference;

        if (_endverse == 0)
        {
             reference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
             reference = $"{_book} {_chapter}:{_verse}-{_endverse}";
        }

        return reference;
      

    }
}