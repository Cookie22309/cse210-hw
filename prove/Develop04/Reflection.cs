class Reflection : Activity
{
    public Reflection()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }
    private List<string> _reflectionPrompt = new List<string>
    
    {
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
    };
    
    private List<string> _reflectionQuestion = new List<string>
    {
        "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
    };
    private void DisplayReflection()
    {

    }
    private void ReflectionPrompt()
    {

    }
    private void ReflectionPause()
    {

    }
    public void Start()
    {
        StartMessage();
        Console.WriteLine($"\nChoose a number between 1 and {_reflectionPrompt.Count}: ");
        int input = int.Parse(Console.ReadLine());
        int choice = input - 1;
        if (choice < 0)
        {
            Console.WriteLine("Try again");
            return;
        }

        if (choice >= _reflectionPrompt.Count)
        {
            Console.WriteLine("Try again");
            return;
        }
        Console.WriteLine("\n" + _reflectionPrompt[choice]);
        Console.WriteLine("\nThink about this...");
        PauseMessage(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + _reflectionQuestion[choice]);
            PauseMessage(5);
            choice++;
            if (choice >= _reflectionQuestion.Count)
            {
                choice = 0;
            }
        }
        EndMessage();
    }
}