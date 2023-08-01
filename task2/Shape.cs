namespace task2;

public class Shape
{
    private Location c = Location();

    public override string ToString()
    {
        return $"Location : {c.x}, {c.y}";
    }

    public virtual double Area()
    {

        return 0;

    }
     public virtual double Perimeter()
     {
        return 0;
     }
}
