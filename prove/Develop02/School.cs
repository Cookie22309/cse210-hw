using System;

public class School
{
    public int _numStudents;
    public int _numTeachers;
    public string _name;

    public void Register()
    {

    }

    public void _ShowDetails()
    {
        Console.WriteLine($"School {_name} has {_numStudents} students and {_numTeachers} teachers.");
    }
}