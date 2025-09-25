using System;

class Program
{
    static void Main(string[] args)
    {
        int y = 5;
        int x = 10;
        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(235);
        myList.Add(345);
        int count = myList.Count();
        Console.WriteLine($"The count is {count}");
        static int multiply(int x, int y)
        //How to write a comment
        {
            int total = x * y;
            return total;
        }
        int answer = multiply(x, y);

        Console.WriteLine($"The answer is {answer}");
        Console.WriteLine(myList);
    }
}