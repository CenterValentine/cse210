using System;

public class GoalManager
{
    List<Goal> _goals;
    double _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
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
            Console.WriteLine("Current Score: " + _score);
        }
        Console.WriteLine("Goodbye!");
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
                Console.Write($"I've made a Simple Goal called: '{name} - {description}'\n\n");
                _goals.Add(simpleGoal);
                break;
            case 2:
                Goal eternalGoal = new EternalGoal(name, description, points);
                Console.Write($"I've made a Eternal Goal called: '{name} - {description}'\n\n");
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.WriteLine("Enter the number of checklists in this goal: ");
                int targetAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points you'd like to earn for completing the goal: \n");
                int bonus = int.Parse(Console.ReadLine());
                Goal checklistGoal = new ChecklistGoal(name, description, points, targetAmount, bonus);
                Console.Write($"I've made a Checklist Goal called '{name}: {description}' {targetAmount}x steps were created.\n\n");
                _goals.Add(checklistGoal);
                break;
        }
    }

    public void DisplayScore()
    { Console.WriteLine($"Score: {_score}"); }

    public void listGoalNames()
    {

        if (_goals.Count == 0)
        { Console.WriteLine("\nNo Goals Found!\nPlease add or load some goals!\n"); }
        else
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
    }

    public void listGoalDetails()
    {
        foreach (Goal goal in _goals)
        { Console.WriteLine(goal.GetDetailsString()); }
    }

    public void saveGoals()
    {
        string fileName = "goals.txt";
        Console.WriteLine("This action will overwrite any previously saved goals. Are you sure you want to continue? (y/n)");

        string response = Console.ReadLine();
        if (response != "y")
        {
            Console.WriteLine("Saving goals cancelled.");
            return;
        }

        System.IO.File.WriteAllText(fileName, string.Empty);

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string fileContents = "";
            foreach (Goal goal in _goals)
            {
                Console.WriteLine("goal: " + goal.GetStringRepresentation());
                fileContents += $"{goal.GetStringRepresentation()}\n";
            }
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(fileContents + "");
            Console.WriteLine($"Your goals have been saved to {fileName}.\n");
        }
    }


    // Logic for loading goals resolves  by looking for unqiue data paterns, a better method could be developed
    public void loadGoals()
    {
        string fileName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        Console.WriteLine("This action will overwrite your current goals. Eternal Goal data will be lost.  Are you sure you want to continue? (y/n)");
        string response = Console.ReadLine();
        if (response != "y")
        {
            Console.WriteLine("Loading goals cancelled.");
            return;
        }
        else
        {
            Console.WriteLine("loading goals...");
            // delete existing classes
            _goals.Clear();
            _score = 0;
        }
        foreach (string line in lines)
        {
            if (line == "") { continue; }
            // Console.WriteLine("line: " + line);
            string[] lineItems = line.Split("|");
            string statusRaw = lineItems[0].ToString();
            bool status = statusRaw == "[X]" ? true : false;
            string name = lineItems[1].ToString().Split(": ")[1];
            // Console.WriteLine("description items: " + lineItems[1].ToString().Split(": ")[1]);
            string description = lineItems[2].ToString().Split(": ")[1];
            int points = int.Parse(lineItems[3].ToString().Split(": ")[1]);
            // Console.WriteLine("name: " + name + " description: " + description + " points: " + points);
            // Console.WriteLine("lineItems.Length: " + lineItems.Length);

            switch (lineItems.Length)
            {
                case 4:
                    Goal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case 5:
                    Goal simpleGoal = new SimpleGoal(name, description, points, status);
                    _goals.Add(simpleGoal);
                    break;
                case 7:
                    // Default values = 0
                    int amountCompleted = int.Parse(lineItems[4].ToString().Split(": ")[1]);
                    int targetAmount = int.Parse(lineItems[5].ToString().Split(": ")[1]);
                    int bonus = int.Parse(lineItems[6].ToString().Split(": ")[1]);
                    _score += amountCompleted * points;
                    if (status)
                    { _score += bonus; }
                    // Console.WriteLine("name: " + name + " description: " + description + " points: " + points + " amountCompleted: " + amountCompleted + " targetAmount: " + targetAmount + " bonus: " + bonus);
                    Goal checklistGoal = new ChecklistGoal(name, description, points, amountCompleted, targetAmount, bonus);
                    // Console.WriteLine("checklistGoal: " + checklistGoal.GetDetailsString());
                    _goals.Add(checklistGoal);
                    break;
            }
            if (status)
            {
                _score += points;

            }
        }
        listGoalNames();
    }

    public void recordEvent()
    {
        Console.WriteLine("Enter the number of your goal you'd like to update: ");
        listGoalNames();
        int goalChoice = int.Parse(Console.ReadLine());
        double pointsEarned = Math.Round(_goals[goalChoice - 1].RecordEvent(), 2);
        Console.WriteLine($"You've earned {pointsEarned} points for this goal!\n");
        _score += pointsEarned;


    }


}