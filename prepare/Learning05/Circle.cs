class Circle: Shape
{
    private double _radius;
    public override double GetArea()
    {
        return 3.1415 * _radius * _radius;
    }
}