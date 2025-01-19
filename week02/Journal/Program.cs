using System;

class Program
{
    static void Main(string[] args)
    {
        string userAnswer = "";
        //int choice = 0;
        
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");
        do 
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userAnswer = Console.ReadLine();
            Console.WriteLine();
            //choice = int.Parse(userAnswer);

            //The option will be validated to call the specific class for every choice

            if ( userAnswer == "1")
            {

                PromptGenerator promptG = new PromptGenerator();
                string prompt = promptG.GetRandomPrompt();
                Console.WriteLine(prompt);
              
                Entry entry = new Entry();
                entry._promptText = prompt;
                entry._entryText =  Console.ReadLine();
                
                DateTime currentTime = DateTime.Now;
                string dateT = currentTime.ToShortDateString();
                entry._date = dateT;

                journal.AddEntry(entry);
                
                



            }
            else if ( userAnswer == "2")
            {
                journal.DisplayAll();
                Console.WriteLine();

            }
            else if ( userAnswer == "3")
            {
                Console.Write("What is the filename? ");
                string fileN = Console.ReadLine();
                journal.LoadFromFile(fileN);

            }
            else if ( userAnswer == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);


            }
            else if ( userAnswer == "5")
            {
                Console.WriteLine("Good bye!");
            }
            else 
            {
                Console.WriteLine("This option is unvalid, try again please");
            }
            
            
        } while (userAnswer != "5");

      






    }
}