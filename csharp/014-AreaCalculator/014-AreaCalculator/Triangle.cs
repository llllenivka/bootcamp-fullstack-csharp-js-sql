using System.Drawing;

namespace _014_AreaCalculator;

public class Triangle : IShape
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }
    
    public Triangle(double a, double b, double c)
    { 
        A = a;
        B = b;
        C = c;
        
        if(!IsTriangle())
            throw new Exception("Triangle is not a triangle");
    }
    
    public double Area()
    {
        double p = (A + B + C) / 2;
        double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        
        return S;
    }

    private bool IsTriangle()
    {
        if(A <= 0 || B <= 0 || C <= 0) return false;
        if(A + B <= C || A + C <= B || B + C <= A) return false;
        return true;
    }
    
}