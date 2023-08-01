namespace task2;

public class Circle : Shape
{
    private double _radius;

    public override double Area()
    {
        return 3.14 * _radius * _radius;
    }

    public override double Perimeter()
    {
        return 2 * 3.14 * _radius;
    }
}