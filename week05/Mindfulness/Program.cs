using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string option;
        bool choice = false;
        string name;
        string description;
        int duration;
        Activity activity;
        BreathingActivity breathingActivity;
        ReflectingActivity reflectingActivity;
        ListingActivity listingActivity;
        List<string> prompts = new List<string>
        {   
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
         };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        List<string> promptsList = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };

  
        while (choice == false)
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a Choice from the menu ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                name = "Breathing Activity";
                description = @"This activity will help you relax by walking you through breathing in and out slowly.
                Clear your mind and focus on your breathing";
            
                           
                
                breathingActivity = new BreathingActivity(name, description);
                breathingActivity.DisplayStartingMessage();
                breathingActivity.ShowSpinner(10);
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                breathingActivity.ShowSpinner(5);

                Console.Clear();
                
                             
                
            }
            else if (option == "2")

            {

                Console.Clear();
                name = "Reflection Activity";
                description = @"This activity will help you reflect on times in your life when you have shown strength and resilience.
                This will help you recognize the power you have and how you can use it in other aspects of your life.";
            

                reflectingActivity = new ReflectingActivity(name, description, prompts, questions);
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.ShowSpinner(10);
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                reflectingActivity.ShowSpinner(5);

                              
                Console.Clear();
               

            }
            else if (option == "3")
            {
                Console.Clear();
                name = "Listing Activity";
                description = @"This activity will help you reflect on the good things in your life by having you list as
                many things as you can in a certain area.";
            

                listingActivity = new ListingActivity(name, description, promptsList);
                listingActivity.DisplayStartingMessage();
                listingActivity.ShowSpinner(10);
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                listingActivity.ShowSpinner(5);

                              
                Console.Clear();
               


            }
            else if (option == "4")
            {
                choice = true;
            }
        
        } 

        
        




    }
}