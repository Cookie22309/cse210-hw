class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breathing.";
    }
    private string _breathIn;
    private string _breathOut;
    private void DisplayBreath()
    {

    }
    private void BreathingPause()
    {

    }
    public void Start()
    {
        StartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            PauseNumber(4);
            Console.Write("\nBreathe out... ");
            PauseNumber(4);
            Console.WriteLine();
        }
        EndMessage();
    }
}