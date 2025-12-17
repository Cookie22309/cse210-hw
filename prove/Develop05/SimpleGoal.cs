class SimpleGoal : Goal
{
    public SimpleGoal(int points, string name, string description, int pointCount = 0, string checkBox = " ") : base(points, name, description, pointCount, checkBox)
    {

    }
    public override List<string> FileFormat ()
    {
        string points = GetPoints().ToString();
        string pointCount = GetPointCount().ToString();
        List<string> load = new List<string>{"SimpleGoal", GetName(), GetDescription(), points, pointCount, GetCheckBox()};

        return load;
    }
    public override void RecordEvent()
    {
        if (GetCheckBox() == " ")
        {
            SetCheckBox();
            SetPointCount(GetPoints());
        }
    }
    public override void Display(int index)
    {
        Console.WriteLine($"{index}. [{GetCheckBox()}] ({GetDescription()}) Points worth: {GetPoints()}");
    }
}