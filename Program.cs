namespace ConsoleApp1Circle;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(6);

        Console.WriteLine(circle1.GetArea());
        Console.WriteLine(circle2.GetArea());

        Circle circle3 = new Circle(3);

        Console.WriteLine(circle3.TransformToBall());

        Triangle triangle1 = new Triangle(3, 3, 3);

        Console.WriteLine(triangle1.GetArea());

    }
}