public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int setTop(int top)
    {
        int numerator = top;
        return numerator;
    }
    public void getBottom()
    {
    }
    public int setBottom(int bottom)
    {
        int denominator = bottom;
        return denominator;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return _top / _bottom;
    }
}