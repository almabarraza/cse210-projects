using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        //Console.Write("What is the magic number? ");
        //string firstAnswer = Console.ReadLine();
        //int magicNumber = int.Parse(firstAnswer);
        int guessNumber;

        do
        {
              

            Console.Write("What is your guess? ");
            string secondAnswer = Console.ReadLine();
            guessNumber = int.Parse(secondAnswer);

            if (number == guessNumber)
            {
                Console.Write("You guessed it!");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
       
             
        } while (number != guessNumber);
    }
}