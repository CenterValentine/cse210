using System;

public class GoalManager
{
    List<Goal> _goals;
    int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void CreateGoal()
    {

        Console.WriteLine("What type best describes your goal?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
        int goalType = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points you'd like to earn for this goal (press enter for random points): ");
        int points = int.Parse(Console.ReadLine());
        switch (goalType)
        {
            case 1:
                Goal simpleGoal = new SimpleGoal(name, description, points, false);
                Console.Write($"I've made a Simple Goal called: {name} - {description} was");
                _goals.Add(simpleGoal);
                break;
            case 2:
                Goal eternalGoal = new EternalGoal(name, description, points);
                Console.Write($"I've made a Eternal Goal called: {name} - {description} was");
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.WriteLine("Enter the number of checklists in this goal: ");
                int targetAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points you'd like to earn for completing the goal: \n");
                int bonus = int.Parse(Console.ReadLine());
                Goal checklistGoal = new ChecklistGoal(name, description, points, targetAmount, bonus);
                Console.Write($"I've made a Checklist Goal called {name}: {description} {targetAmount}x steps were ");
                _goals.Add(checklistGoal);
                break;
        }
        Console.Write("created.\n\n");
    }

    public void DisplayScore()
    { Console.WriteLine($"Score: {_score}"); }

    public void listGoalNames()
    {
        Console.WriteLine("Here are your goals: ");
        int nameCount = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{nameCount}: {goal.GetDetailsString()}");
            nameCount++;
        }
        Console.WriteLine("\n\n");
    }


    public void listGoalDetails()
    {
        foreach (Goal goal in _goals)
        { Console.WriteLine(goal.GetDetailsString()); }
    }

    public void saveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string fileContents = "";
            foreach (Goal goal in _goals)
            {
                Console.WriteLine("goal: " + goal.GetStringRepresentation());
                fileContents += $"{goal.GetStringRepresentation()}\n";
            }
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(fileContents);
            Console.WriteLine($"Your goals have been saved to {fileName}.\n");
        }
    }

    public void loadGoals()
    {
        string fileName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine("line: " + line);
            // string[] parts = line.Split(",");
        }
    }

    public void recordEvent()
    {
        Console.WriteLine("Enter the number of your goal you'd like to update: ");
        listGoalNames();
        int goalNumber = int.Parse(Console.ReadLine());
        if (goalNumber > _goals.Count + 1)
        { _goals[goalNumber - 1].RecordEvent(); }
        else
        { Console.WriteLine("Invalid goal number:"); }
    }

    public void start()
    {
        Console.WriteLine("Welcome to the Goal Manager!\nLets get ready to set some goals!\n");
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("Select one of the following: \n1. Create a new goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Exit\n");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    listGoalNames();
                    break;
                case 3:
                    saveGoals();
                    break;
                case 4:
                    loadGoals();
                    break;
                case 5:
                    recordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}