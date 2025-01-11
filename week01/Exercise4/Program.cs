using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        float sumNumbers = 0; 
        int size = 0;
        float average = 0;
        int largestNumber = 0;


        do
        {
                 Console.Write("Enter number:");
                 string answer = Console.ReadLine();
                 number = int.Parse(answer);

                 if (number != 0)
                 {
                    numbers.Add(number);
                 }

               
        } while (number != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            sumNumbers = sumNumbers + numbers[i];

            if ( numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }

        size = numbers.Count;
        average = sumNumbers / size;

        Console.WriteLine($"The sum is: {sumNumbers} ");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
   
    }
} 