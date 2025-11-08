class Listing : Activity
{
    private List<string> _listingPrompt = new List<string>
    {
        "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
    };
    private void DisplayListing()
    {

    }
    private void RandomListingPrompt()
    {

    }








    

    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.";
    }

    public void Start()
    {
        StartMessage();

        Random rand = new Random();
        string prompt = _listingPrompt[rand.Next(_listingPrompt.Count)];
        Console.WriteLine("\n" + prompt);
        Console.WriteLine("You may begin in:");
        PauseNumber(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            responses.Add(item);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndMessage();
    }
}