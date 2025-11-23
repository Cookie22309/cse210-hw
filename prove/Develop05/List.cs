class List
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
    public void ListGoals()
    {
        Console.Clear();
        int count = 0;
        int totalPoints = 0;
        Console.WriteLine($"Total points: {totalPoints}");
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goalList)
        {
            count ++;
            totalPoints += goal.GetPointCount();
            Console.Write($"{ count}.  ");
            switch(goal)
            {
                case SimpleGoal:
                    Console.WriteLine($"[{goal.FileFormat()[5]}]  ({goal.FileFormat()[2]})  Points worth: {goal.FileFormat()[3]}");
                break;
                case ChecklistGoal:
                    Console.WriteLine($"[{goal.FileFormat()[5]}]  ({goal.FileFormat()[2]})  Points worth: {goal.FileFormat()[3]}");
                break;
                case EternalGoal:
                Console.WriteLine($"[{goal.FileFormat()[5]}]  ({goal.FileFormat()[2]})  {goal.FileFormat()[7]}/{goal.FileFormat()[8]}\n\tPoints per task: {goal.FileFormat()[6]}  Points on completion: {goal.FileFormat()[3]}");
                break;
            }
        }
        if (_goalList.Count() == 0)
        {
            Console.WriteLine("There are no goals yet");
        }
        Console.WriteLine($"\nTotal points: {totalPoints}\n");
    }
    public void RecordEvent()
    {
        Console.Clear();
        ListGoals();
        Console.WriteLine("Which goal did you complete: ");
        int input = int.Parse(Console.ReadLine()) - 1;
        int add = _goalList[input].GetPoints();
        int currentPoints = _goalList[input].GetPointCount();
        switch (_goalList[input])
        {
            case SimpleGoal:
                if (_goalList[input].GetCheckBox() == " ")
                {
                    _goalList[input].SetCheckBox();
                    _goalList[input].SetPointCount(add);
                }
                Console.Clear();
                Console.WriteLine("Goal completion noted:\n");
            break;
            case ChecklistGoal:
                _goalList[input].SetPointCount(add + currentPoints);
                Console.Clear();
                Console.WriteLine("Goal completion noted:\n");
            break;
            case EternalGoal:
                int numerator = int.Parse(_goalList[input].FileFormat()[7]);
                int denominator = int.Parse(_goalList[input].FileFormat()[8]);
                if (numerator < denominator)
                {
                    switch (_goalList[input])
                    {
                        case EternalGoal goal:
                            goal.SetNumerator(numerator + 1);
                            if (numerator == denominator - 1)
                            {
                                goal.SetPointCount(currentPoints + goal.GetProgressPoints() + add);
                                goal.SetCheckBox();
                            }
                            else
                            {
                                goal.SetPointCount(currentPoints + goal.GetProgressPoints());
                            }
                            break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Goal completion noted:\n");
            break;
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
}