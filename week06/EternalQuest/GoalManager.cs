using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;


    public GoalManager()
    {
        _score = 0;

    }

    public void Start()
    {
        bool quit = false;

        while(quit == false)
        {
            string choice;
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options\n");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();

            }
            else if(choice == "2")
            {  
              ListGoalDetails();
            }
            else if(choice == "3")
            {
                SaveGoal();

            }
            else if(choice == "4")
            {
                LoadGoals();

            }
            else if(choice == "5")
            {
                RecordEvent();
                

            }
            else if(choice == "6")
            {
                quit = true;       
            }
        }
            
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");

    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:\n");
        int count = 0;
        foreach(Goal goal in _goals)
        {
            count = count + 1;
            string goals = goal.GetName();
            
            Console.WriteLine($"{count}. {goals}");
        }

    }

    public void ListGoalDetails()
    { 
         string goalDetails;

                foreach( Goal goal in _goals)
                {
                    goalDetails = goal.GetDetailString();
                    Console.WriteLine(goalDetails);
                }
        
    }

    public void CreateGoal()
    {
        string typeGoal;
        string nameGoal;
        string description;
        string points;
        
        do
        {
        Console.WriteLine("The types of Goals are:\n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");
        Console.WriteLine("Which type of Goal would you like to create? ");
        typeGoal = Console.ReadLine();
        } while (typeGoal != "1" && typeGoal != "2" && typeGoal != "3");

        Console.WriteLine("What is the name of your Goal? ");
        nameGoal = Console.ReadLine();
        Console.WriteLine("What is your short description of it? ");
        description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();

        if(typeGoal == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(nameGoal, description, points, false);
            _goals.Add(simpleGoal);

        }
        else if(typeGoal == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(nameGoal, description, points);
            _goals.Add(eternalGoal);
            
        }
        else if(typeGoal == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            CheckListGoal checkListGoal = new CheckListGoal(nameGoal, description, points, target, bonus, 0);
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("unvalid option");
        }
        
     
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplished? ");
        string option = Console.ReadLine();
        int numberOption = int.Parse(option);

        numberOption = numberOption - 1;
        Goal goal = _goals[numberOption];
        
        if (goal.IsComplete() == false)
        {
            goal.RecordEvent();
            string points = goal.GetPoints();
            Console.WriteLine($"Congratulations!! You have earned {points}");
            _score = _score + int.Parse(points);

        }
        else
        {
            Console.WriteLine("This goal has already complited");

        }
            
        

        

    }

    public void SaveGoal()
    {
        string fileName;
        Console.WriteLine("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
    {

        outputFile.WriteLine(_score.ToString());

        foreach (Goal goal in _goals)
        {
            string representation;

            representation = goal.GetStringRepresentation();
            outputFile.WriteLine(representation);
                 
        }
    }

    }

    public void LoadGoals()
    {
        string fileName;
        Console.WriteLine("What is the filename for the goal file? ");
        fileName = Console.ReadLine();
       
        string[] goals = System.IO.File.ReadAllLines(fileName);

        

        foreach (string goal in goals)
        {
                string[] parts = goal.Split(",");

                if(goal.Length == 1)
                {
                    string goalscore = parts[0];
                    Console.WriteLine(goalscore);
                }
                else
                {
                    string goalName; 
                    string goalDescription;
                    string goalPoints;
                    string goalComplited;
                    string goalBonus;
                    string goalTarget;
                    string goalAmoutComplited;
                    bool complited = false;
                    string[] typeGoal = parts[0].Split(":");
                    
                    if(typeGoal[0] == "Simple Goal")
                    {   
                         goalName = typeGoal[1];    
                         goalDescription = parts[1];
                         goalPoints = parts[2];
                         goalComplited = parts[3];
                         if(goalComplited == "True")
                         {
                            complited = true;
                         }
                         else 
                         {
                            complited = false;
                         }
                       //  goalName = $"{typeGoal[0]}{goalName}";
                        // Console.WriteLine($"[ ] {goalName},{goalDescription},{goalPoints},{goalComplited}");
                         SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, complited);
                         _goals.Add(simpleGoal);

                    }
                    else if(typeGoal[0] == "Eternal Goal")
                    {   
                         goalName = typeGoal[1];    
                         goalDescription = parts[1];
                         goalPoints = parts[2];
                         //goalName = $"{typeGoal[0]}{goalName}";
                        // Console.WriteLine($"[ ] {goalName},{goalDescription},{goalPoints}");                        
                         EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                         _goals.Add(eternalGoal);
                                               
                    }
                    else if(typeGoal[0] == "CheckList Goal")
                    {
                        goalName = typeGoal[1];    
                        goalDescription = parts[1];
                        goalPoints = parts[2];
                        goalBonus = parts[3];
                        goalTarget = parts[4];
                        int amountComplited = int.Parse(goalAmoutComplited = parts[5]);
                       // goalName = $"{typeGoal[0]}{goalName}";
                       // Console.WriteLine($"[ ] {goalName},{goalDescription},{goalPoints},{goalBonus},{goalTarget},{goalAmoutComplited}");                       
                        CheckListGoal eternalGoal = new CheckListGoal(goalName, goalDescription, goalPoints, int.Parse(goalTarget), int.Parse(goalBonus), amountComplited);
                        _goals.Add(eternalGoal);
                                                                                            
                    }

                    
                }
          
        }

    }




}