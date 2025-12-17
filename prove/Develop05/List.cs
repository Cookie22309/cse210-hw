class GoalList
{
    private List<Goal> _goalList = new List<Goal>();
    public void CreateGoal()
    {
        int program = 1;
        string inputString;
        int input;
        while (program != 0)
        {
            string name;
            string description;
            int points;
            Console.Clear();
            Console.Write("\nSelect a goal type:\n1. Simple Goal\n2. Habit Goal\n3. Checklist Goal\nSelect a choice from the menu: ");
            inputString = Console.ReadLine();
            input = int.Parse(inputString);
            switch (input)
            {
                case 1:
                    Console.WriteLine("Name of the goal: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Description of the goal:");
                    description = Console.ReadLine();
                    Console.WriteLine("Points goal is worth at completion:");
                    points = int.Parse(Console.ReadLine());
                    SimpleGoal sGoal = new SimpleGoal(points, name, description);
                    _goalList.Add(sGoal);
                    program = 0;
                    Console.Clear();
                    Console.WriteLine("Goal Added\n");
                    break;
                case 2:
                    Console.WriteLine("Name of the goal: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Description of the goal:");
                    description = Console.ReadLine();
                    Console.WriteLine("Points goal is worth at completion:");
                    points = int.Parse(Console.ReadLine());
                    ChecklistGoal cGoal = new ChecklistGoal(points, name, description);
                    _goalList.Add(cGoal);
                    program = 0;
                    Console.Clear();
                    Console.WriteLine("Goal Added\n");
                    break;
                case 3:
                    int numerator = 0;
                    int denominator;
                    int pointBonus;
                    Console.WriteLine("Name of the goal: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Description of the goal:");
                    description = Console.ReadLine();
                    Console.WriteLine("Times until finished:");
                    denominator = int.Parse(Console.ReadLine());
                    Console.WriteLine("Points after each goal completion:");
                    pointBonus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bonus points for completing overall goal:");
                    points = int.Parse(Console.ReadLine());
                    EternalGoal eGoal = new EternalGoal(points, name, description, numerator, denominator, pointBonus);
                    _goalList.Add(eGoal);
                    program = 0;
                    Console.Clear();
                    Console.WriteLine("Goal Added\n");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select an option\n");
                    break;
            }
            Console.Clear();
        }
    }
    
    public void SaveToFile()
    {
        Console.Write("\nPlease input a file name:\n  > ");
        string filename = Console.ReadLine();
        var lines = new List<string>();
        foreach (Goal goal in _goalList)
        {
            var data = goal.FileFormat();
            lines.Add(string.Join("~", data));
        }
        File.WriteAllLines(filename, lines);
    }
    public void LoadFromFile()
    {
        Console.Write("\nPlease input a file name:\n  > ");
        string filename = Console.ReadLine();
        string text = File.ReadAllText(filename);
        string[] lines = text.Split('\n');
        Console.WriteLine($"Loading in entries from {filename}...");
        foreach (string line in lines)
        {
            string[] goalAttributes = line.Split("~");
            string name = goalAttributes[1];
            string description = goalAttributes[2];
            int points = int.Parse(goalAttributes[3]);
            int pointCount = int.Parse(goalAttributes[4]);
            string checkBox = goalAttributes[5];
            switch (goalAttributes[0])
            {
                case "EternalGoal":
                    int progressPoints = int.Parse(goalAttributes[6]);
                    int progressNumerator = int.Parse(goalAttributes[7]);
                    int progressDenominator = int.Parse(goalAttributes[8]);
                    EternalGoal eGoal = new EternalGoal(points, name, description, progressNumerator, progressDenominator, progressPoints, pointCount, checkBox);
                    _goalList.Add(eGoal);
                break;
                case "ChecklistGoal":
                    ChecklistGoal cGoal = new ChecklistGoal(points, name, description, pointCount, checkBox);
                    _goalList.Add(cGoal);
                break;
                case "SimpleGoal":
                    SimpleGoal sGoal = new SimpleGoal(points, name, description, pointCount, checkBox);
                    _goalList.Add(sGoal);
                break;
            }
        }
    }
    public List<Goal> GetGoals()
    {
        return _goalList;
    }
     public void Clear()
    {
        List<Goal> clear = new List<Goal>();
        _goalList = clear;
        Console.Clear();
        Console.WriteLine("Goals cleared\n");
    }
    public void ListGoals()
    {
        Console.Clear();
        int totalPoints = 0;
        foreach (Goal g in _goalList)
        {
            totalPoints += g.GetPointCount();
        }
        Console.WriteLine("Total points: " + totalPoints);
        Console.WriteLine("The goals are:");
        if (_goalList.Count == 0)
        {
            Console.WriteLine("There are no goals yet");
        }
        else
        {
            int count = 1;
            foreach (Goal goal in _goalList)
            {
                goal.Display(count);
                count = count + 1;
            }
        }

        Console.WriteLine($"\nTotal points: {totalPoints}\n");
    }
    public void RecordEvent()
    {
        Console.Clear();
        ListGoals();
        Console.Write("Which goal did you complete: ");
        int input = int.Parse(Console.ReadLine()) - 1;
        if (input >= 0)
        {
            if (input < _goalList.Count)
            {
                _goalList[input].RecordEvent();
                Console.Clear();
                Console.WriteLine("Goal completion noted:\n");
            }
        }
    }
}