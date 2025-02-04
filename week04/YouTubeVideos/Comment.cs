using System;
using System.Reflection.PortableExecutable;

public class Comment
{
    private string _personName;
    private string _commentText;

    public Comment(string text, string name)
    {
        _personName = name;
        _commentText = text;

    }

    public string GetDislayComment()
    {
        string comment = $"{_personName} - {_commentText}";
        return comment;
    }


    


}