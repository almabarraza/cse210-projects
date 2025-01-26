using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private  List<Word> _words = new List<Word>();
  

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        List<string> listW = text.Split(" ").ToList();

                
        foreach (string textPart in listW)
        {
             
                
             Word word1 = new Word (textPart);
             _words.Add(word1);
        }
             

       
    }

    public void HideRandomWords(int numberToHide)

    {
        for(int i=1; i<=numberToHide; i++)
        {
            Random random = new Random();

            int random_number = random.Next(0,_words.Count);
            _words[random_number].Hide();
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            result = $"{result} {word.GetDisplayText()}";
            
        }
       
            
        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
    
}