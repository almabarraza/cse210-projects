using System;
using System.Collections.Generic;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
    private string _name;
    private string _description;


    public ListingActivity(string name, string description, List<string> prompsList): base(name, description)
    {
        _name = name;
        _description = description;
        _prompts = prompsList;


    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

    }

    public void GetRandomPrompt()
    {
        string randomPrompt;

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);

       

    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string userTyping;
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        _count = 0;

        while (DateTime.Now < endTime)
        {
           
           Console.Write(">");
           userTyping = Console.ReadLine();
           userList.Add(userTyping);
            
            _count = _count + 1;
        }

        return userList;


           
    }


    



}

