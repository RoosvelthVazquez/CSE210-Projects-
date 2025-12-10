using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== Eternal Quest Program ===");
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine();
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goasl");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("¡Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n=== Creat New Goal ===");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        
        string typeChoice = Console.ReadLine();
        
        Console.Write("Whatis the name of your goal?: ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        
        Console.Write("What is  the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple goal successfully created.");
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal goal successfully created.");
                break;
            case "3":
                Console.Write("Number of times required for the bonus: ");
                int target = int.Parse(Console.ReadLine());
                
                Console.Write("Bonus points upon completion: ");
                int bonus = int.Parse(Console.ReadLine());
                
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine("Checklist goal successfully created.");
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\n=== List Goals ===");
        
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been recorded.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals for recording events.");
            return;
        }

        Console.WriteLine("\n=== Register Event ===");
        ListGoalDetails();
        Console.Write("Select the goal number to register: ");
        
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            
            // Add points
            _score += selectedGoal.Points;
            
            // If it's cheack list, add bonus.
            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                int bonus = ((ChecklistGoal)selectedGoal).GetBonus();
                _score += bonus;
                Console.WriteLine($"Congratulations! You completed the goal and earned {bonus} bonus points!");
            }
            
            Console.WriteLine($"Event recorded. You earned {selectedGoal.Points} points.");
            
            
            if (selectedGoal.IsComplete())
            {
                Console.WriteLine($"¡Goal '{selectedGoal.ShortName}' completed!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Option.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Save score
                writer.WriteLine(_score);
                
                // Save goal
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            
            Console.WriteLine("Goals successfully saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();

        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                // uoloead score
                _score = int.Parse(reader.ReadLine());
                
                // clean current list
                _goals.Clear();
                
                // upload goals
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string[] data = parts[1].Split(',');
                    
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(data[3]);
                            SimpleGoal simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                            if (isComplete) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                            
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                            break;
                            
                        case "ChecklistGoal":
                            ChecklistGoal checklistGoal = new ChecklistGoal(
                                data[0], 
                                data[1], 
                                int.Parse(data[2]), 
                                int.Parse(data[4]), 
                                int.Parse(data[3]));
                            
                            // Restore completed amount
                            int amountCompleted = int.Parse(data[5]);
                            for (int i = 0; i < amountCompleted; i++)
                            {
                                checklistGoal.RecordEvent();
                            }
                            
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            
            Console.WriteLine("Goals successfully uploaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading: {ex.Message}");
        }
    }
}