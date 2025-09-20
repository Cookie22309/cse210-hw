using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int numgrade = int.Parse(grade);
        string letgrade = "";

        if (numgrade >= 90)
        {
            letgrade = "A";
        }
        else if (numgrade >= 80 && numgrade < 90)
        {
            letgrade = "B";
        }
        else if (numgrade >= 70 && numgrade < 80)
        {
            letgrade = "C";
        }
        else if (numgrade >= 60 && numgrade < 70)
        {
            letgrade = "D";
        }
        else
        {
            letgrade = "F";
        }

        Console.WriteLine($"You have a {letgrade} in the class!");
        if (numgrade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class! See you next year!!!");
        }
        else
        {
            Console.WriteLine("Darn, you didnt pass...better luck next time!");
        }
    }
}