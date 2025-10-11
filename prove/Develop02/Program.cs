static class Program
{
    static public string displayMenu()
    {
        Console.WriteLine("Menu:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");
        string menuChoice = Console.ReadLine();
        return menuChoice;
    }
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Entry promptList = new Entry();
        string choice = "";
        while (choice != "5")
        {
        choice = displayMenu();
            if (choice == "1")
            {
                string randomPrompt = promptList.getRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._prompt = randomPrompt;
                entry._response = response;
                entry._date = DateTime.Now.ToShortDateString();
                myJournal.addEntry(entry);
                Console.WriteLine("Entry added!\n");
            }
            else if (choice == "2")
            {
                myJournal.displayJournal();
            }
            else if (choice == "3")
            {
                myJournal.save();
            }
            else if (choice == "4")
            {
                myJournal.load();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Quitting...");
            }
        }  
    }       
}