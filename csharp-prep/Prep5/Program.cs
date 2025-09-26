using System;
class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        int birthYear;
       
        void PromtUserBirthYear(out int year)
        {
            Console.Write("What year were you born? ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out year))
            {
                Console.Write("Invalid input. Please enter a valid year: ");
                input = Console.ReadLine();
            }
        }
        void SquareNumber(int num, string name)
        {
            int square = num * num;
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        void DisplayResult(int year, string name)
        {
            int age = 2025 - year;
            Console.WriteLine($"{name}, you will turn {age} this year."); 
        }
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        PromtUserBirthYear(out birthYear);
        SquareNumber(UserNumber, UserName);
        DisplayResult(birthYear, UserName);
    }
}