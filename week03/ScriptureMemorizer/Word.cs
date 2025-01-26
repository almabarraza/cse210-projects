using System;


public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        
    }


    public void Hide()
    {
        _isHidden = true;
        
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
        return false;
        }
        
    }


    public string GetDisplayText()
    {
        string wordHidden = "";

        if (_isHidden == true)
        {
            int characters = _text.Length;

            for (int i=1; i<=characters; i++)
            {
                wordHidden = $"{wordHidden}_";
                

            }
            return wordHidden;
        }
        else
        {
            return _text;
        }

        
    }

}

