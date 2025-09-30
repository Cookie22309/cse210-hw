using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        School school1 = new School();
        school1._name = "BYU-I";
        school1._numStudents = 32000;
        school1._numTeachers = 500;

        school1._ShowDetails();
    }
}