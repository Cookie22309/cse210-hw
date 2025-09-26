using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>();
        int number = 1;
        do
        {
            Console.WriteLine("What is your number?");
            string input = Console.ReadLine();
            number = int.Parse(input);
            myList.Add(number);
        } while (number != 0);
        int sum = myList.Sum();
        double average = myList.Average();
        int max = myList.Max();
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");
    }
}