using System;
class Program
{
    static void Main(string[] args)
    {
        int program = 1;
        string inputString;
        int input;
        GoalList goals = new GoalList();
        while (program != 0)
        {
            Console.Clear();
            Console.Write("\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Clear Goals\n7. Quit\nSelect a choice from the menu: ");
            inputString = Console.ReadLine();
            input = int.Parse(inputString);
            switch (input)
            {
                case 7:
                    program = 0;
                    break;
                case 1:
                    goals.CreateGoal();
                    break;
                case 2:
                    goals.ListGoals();
                    break;
                case 3:
                    goals.SaveToFile();
                    break;
                case 4:
                    goals.LoadFromFile();
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
                case 6:
                    goals.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }


    }
}