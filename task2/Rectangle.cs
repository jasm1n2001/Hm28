namespace task2;

public class Rectangle : Shape
{
    private double _saide1;
    private double _saide2;
     


     public Rectangle(double side1, double side2)
     {
        _saide1 = side1;
        _saide2 = side2;

     }

    public override double Area()
    {
        return _saide1 * _saide2;

    }

    public override double Perimeter()
    {
        return 2*(_saide1 + _saide1);
    }
}

