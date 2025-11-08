using System;
class Program
{
    static void Main(string[] args)
    {
    bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Breathing breathing = new Breathing();
                    breathing.Start();
                    break;
                case "2":
                    Reflection reflection = new Reflection();
                    reflection.Start();
                    break;
                case "3":
                    Listing listing = new Listing();
                    listing.Start();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Enjoy your day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}