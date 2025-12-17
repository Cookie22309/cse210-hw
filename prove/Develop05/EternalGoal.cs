class EternalGoal : Goal
{
    private int _progressNumerator;
    private int _progressDenominator;
    private int _progressPoints;
    public EternalGoal(int points, string name, string description, int numerator, int denominator, int pointBonus, int pointCount = 0, string checkBox = " ") : base(points, name, description, pointCount, checkBox)
    {
        _progressNumerator = numerator;
        _progressDenominator = denominator;
        _progressPoints = pointBonus;
    }
    public void SetNumerator(int input)
    {
        _progressNumerator = input;
    }
    public void SetDenominator(int input)
    {
        _progressDenominator = input;
    }
    public int GetNumerator()
    {
        return _progressNumerator;
    }
    public int GetDenominator()
    {
        return _progressDenominator;
    }
    public int GetProgressPoints()
    {
        return _progressPoints;
    }
    public override List<string> FileFormat ()
    {
        string progressPoints = _progressPoints.ToString();
        string progressNumerator = _progressNumerator.ToString();
        string progressDenominator = _progressDenominator.ToString();
        string pointCount = GetPointCount().ToString();
        string points = GetPoints().ToString();
        string checkBox = GetCheckBox();
        List<string> load = new List<string>{"EternalGoal", GetName(), GetDescription(), points, pointCount, checkBox, progressPoints, progressNumerator, progressDenominator}; 
        return load;
    }
    public override void Display(int index)
    {
        Console.WriteLine($"{index}. [{GetCheckBox()}] ({GetDescription()}) {_progressNumerator}/{_progressDenominator}\n\tPoints per task: {_progressPoints} Points on completion: {GetPoints()}");
    }
    public override void RecordEvent()
    {
        if (_progressNumerator < _progressDenominator)
        {
            _progressNumerator = _progressNumerator + 1;
            if (_progressNumerator == _progressDenominator)
            {
                SetPointCount(GetPointCount() + _progressPoints + GetPoints());
                SetCheckBox();
            }
            else
            {
                SetPointCount(GetPointCount() + _progressPoints);
            }
        }
    }
}