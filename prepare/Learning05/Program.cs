using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Square square = new Square();

                    break;
                case "2":
                    Rectangle rectangle = new Rectangle();

                    break;
                case "3":
                    Circle circle = new Circle();
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