using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long in seconds, would you like for your sesion? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        
        

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(10);
        Console.WriteLine($"You have complited another {_duration} seconds of the {_name}");
        

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {    
                i = 0;
            }
        }        

    }

    public void ShowCountDown(int seconds)
    {   
           int i = seconds;
       
        
            while (i > 0)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                i--;
            }

    }







}