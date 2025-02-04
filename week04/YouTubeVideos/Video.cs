using System;
using System.Collections.Generic;


public class Video
{

    private string _title;
    private string _author;
    private int _lenghtInSeconds;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author,int lenthInSeconds, List<Comment>videoComments)
    {
        _title = title;
        _author = author;
        _lenghtInSeconds = lenthInSeconds;
        _comments = videoComments;
       
    }


    public void DisplayNumberOfComments()
    {
        int numberComments = _comments.Count;
        Console.WriteLine($"Number Of Comments {numberComments}");
        foreach(Comment commentDisplay in _comments)
        {
            string displaycomment = commentDisplay.GetDislayComment();
            Console.WriteLine(displaycomment);
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght: {_lenghtInSeconds}");
        Console.WriteLine();
    
    }








}