using System;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        int guess = 0;
        do
        {
            Console.WriteLine("Guess what the number is!");
            string GuessInput = Console.ReadLine();
            guess = int.Parse(GuessInput);
            if (guess == number)
            {
                Console.WriteLine("Correct!");
            }
            if (guess > number)
            {
                Console.WriteLine("Lower...");
            }
            if (guess < number)
            {
                Console.WriteLine("Higher...");
            }
        } while (guess != number);
    }
}