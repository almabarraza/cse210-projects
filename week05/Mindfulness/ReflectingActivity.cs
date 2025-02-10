using System;
using System.Collections.Generic;

public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private string _name;
    private string _description;


    public ReflectingActivity(string name, string description, List<string>prompts, List<string>questions): base(name, description)
    {
        _name = name;
        _description = description;
        _prompts = prompts;
        _questions = questions;


    }

    public void Run()
    {

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, please press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

      
        while (DateTime.Now < endTime)
            
        {
            DisplayQuestions();
            ShowSpinner(10);
        }



    }

    public string GetRandomPrompt()
    {
        string randomPrompt;

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        string randomQuestion;

        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        randomQuestion = _questions[randomIndex];
        
        return randomQuestion;
         
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"---{randomPrompt}---");

    }


    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
        
    }

}