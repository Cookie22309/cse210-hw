class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n_description\n\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        PauseMessage(3);
    }
    public void EndMessage()
    {
        Console.WriteLine("\nNice job!");
        PauseMessage(2);
        Console.WriteLine($"\nYou have completed the {_name} Activity for {_duration} seconds.");
        PauseMessage(3);
    }
    public void PauseMessage(int seconds)
    {
        string[] loadingSymbol = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(loadingSymbol[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % loadingSymbol.Length;
        }
    }
    public void PauseNumber(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}