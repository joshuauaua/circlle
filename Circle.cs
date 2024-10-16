namespace ConsoleApp1Circle;

public class Circle
{
    private double Radie { get; set; }
    
    public Circle(double radie)
    {
        this.Radie = radie;
    }
    
    public double GetArea()
    {
        double area = Math.Pow(Radie, 2) * Math.PI;
        return area;
    }

    public double TransformToBall()
    {
        double volume = ((4/3) * (Math.Pow(Radie, 3) * Math.PI));
        return volume;
    }
    
    
}