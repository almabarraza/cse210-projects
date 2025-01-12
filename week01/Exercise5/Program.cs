using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromtUserNumber();
        int squareN = SquareNumber(userNumber);
        DisplayResult(userName, squareN);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number *  number;
            return squareNumber;
        }

        static void DisplayResult(string name, int squareNumber)
        {
            Console.Write($"{name}, the square of your number is: {squareNumber}");
        }





    }
}