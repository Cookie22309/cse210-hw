abstract class Goal
{
    private string _checkBox = " ";
    private int _points;
    private string _name;
    private string _description; 
    private int _pointCount = 0;
    public Goal(int points, string name, string description, int pointCount = 0, string checkBox = " ")
    {
        _points = points;
        _name = name;
        _description = description;
        _pointCount = pointCount;
        _checkBox = checkBox;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetCheckBox()
    {
        return _checkBox;
    }
    public int GetPoints()
    {
        return _points;
    }
    public int GetPointCount()
    {
        return _pointCount;
    }
    public void SetCheckBox()
    {
        _checkBox = "x";
    }
    public void SetPointCount(int add)
    {
        _pointCount += add;
    }
    public abstract List<string> FileFormat();
}