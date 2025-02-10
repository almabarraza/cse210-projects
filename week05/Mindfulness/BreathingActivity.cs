using System;
using System.ComponentModel;

public class BreathingActivity: Activity
{
    private string _name;
    private string _description;


    public BreathingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;       
       


    }

    public void Run()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

      
        while (DateTime.Now < endTime)
            
        {
        Console.WriteLine(" Breathe in...");
        ShowCountDown(4);
        Console.WriteLine(" Breathe out...\n");
        ShowCountDown(6);

        
        }

       

    }


}