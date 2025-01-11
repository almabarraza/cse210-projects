using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type your grade percentage: " );
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letter;
        

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >=80)
        {
            letter = "B";
        }
        else if (gradePercentage >=70)
        {
            letter ="C";
        }
        else if (gradePercentage >=60)
        {
            letter ="D";
        }
        else 
        {
            letter ="F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }

        Console.Write($"Your letter grade is {letter} ");
    }
}