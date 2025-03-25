namespace _014_AreaCalculator;

public class Circle : IShape
{
    public double Radius { get; private set; }
    public Circle(double radius)
    {
        if(radius <= 0)
            throw new ArgumentException("Radius must be greater than zero");
        Radius = radius;
    }
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}