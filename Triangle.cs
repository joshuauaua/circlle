namespace ConsoleApp1Circle;

public class Triangle
{
    private double A { get; set; }
    private double B { get; set; }
    private double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        this.A = a;
        this.B = b;
        this.C = c;
    }

    public double GetArea()
    {
        double s = ((A + B + C) / 2);
        double area = Math.Sqrt(s* (s - A) * (s - B) * (s - C));
        return area;
    }
    
    
}