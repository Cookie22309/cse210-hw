using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        string x = Console.ReadLine();

        int y = int.Parse(x);

        while (y > 0)
        {

            y -= 1;
            Console.WriteLine(y);

        }
    }
}