using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Running running = new Running("20 Feb 2024", 60, "Running", 8.00);
        activities.Add(running);

        Cycling cycling = new Cycling("12 Mar 2024", 40, "Cycling", 15.5);
        activities.Add(cycling);

        Swimming swimming = new Swimming("05 Jul 2024", 30, "Swimming", 10);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
            
        }

        





    }
}