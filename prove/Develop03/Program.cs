using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, "5-6");
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);
        int wordsToHide = ChooseDifficulty();
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}\nPress Enter to continue or type 'quit' to end: ");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            scripture.HideRandomWords(wordsToHide);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine($"{scripture.GetDisplayText()}\nAll words are hidden. Great job memorizing!");
                break;
            }
        }
    }
    private static int ChooseDifficulty()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose a difficulty level:\n1. Easy   (hide 2 words each time)\n2. Medium (hide 3 words each time)\n3. Hard   (hide 4 words each time)\nEnter 1, 2, or 3: ");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                return 2;
            }
            else if (choice == "2")
            {
                return 3;
            }
            else if (choice == "3")
            {
                return 4;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.\nPress any key to try again...");
                Console.ReadKey();
            }
            
        }

    }
}