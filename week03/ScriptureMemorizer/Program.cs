using System;
using System.Collections.Generic;
using System.IO;

// In order to exceed requirements I added code for loading the scripture from a file

class Program
{
    static void Main(string[] args)
    
    {
        
        string directory = Directory.GetCurrentDirectory();
        string filePath = @$"{directory}\singleverse.csv";
        string[] lines = System.IO.File.ReadAllLines(filePath);

        string quit = "";
        Scripture scripture = null;

        
        foreach (string l in lines)
        {
            string[] fileParts = l.Split("|");
            string book = fileParts[0];
            int chapter = int.Parse(fileParts[1]);
            string verse = fileParts[2];
            string text = fileParts[3];

            string[] verseParts = verse.Split("-");
            int startverse = int.Parse(verseParts[0]);
            Reference reference1;
    
            if (verseParts.Count()>1)
            {
                int endverse = int.Parse(verseParts[1]);
                reference1 = new Reference(book,chapter,startverse,endverse);
            }
            else
            {
                reference1 = new Reference(book,chapter,startverse);
            }      
       
           
              

          

            scripture = new Scripture(reference1,text);
           
          
        }

        do
        { 
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            quit = Console.ReadLine();
            Console.Clear();
            scripture.HideRandomWords(3);
            

            if (scripture.IsCompletelyHidden() == true)
            {
                quit = "quit";
            }
     
        }while (quit != "quit");
    }
}