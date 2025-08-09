// Abstract base class
abstract class Shape
{
    public abstract double GetArea();
    
    public virtual string GetShapeName()
    {
        return "Shape";
    }
}

// Derived class Circle
class Circle : Shape
{
    public double Radius { get; set; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    public override string GetShapeName()
    {
        return "Circle";
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    
    public override double GetArea()
    {
        return Width * Height;
    }
    
    public override string GetShapeName()
    {
        return "Rectangle";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of shapes
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);
        
        // Display areas
        Console.WriteLine($"Area of {circle.GetShapeName()}: {circle.GetArea():F2}");
        Console.WriteLine($"Area of {rectangle.GetShapeName()}: {rectangle.GetArea():F2}");
        
        // Demonstrate polymorphism with a list of shapes
        Console.WriteLine("\nDemonstrating polymorphism with a list of shapes:");
        List<Shape> shapes = new List<Shape>
        {
            new Circle(3.0),
            new Rectangle(5.0, 4.0),
            new Circle(2.5)
        };
        
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetShapeName()}: {shape.GetArea():F2}");
        }
    }
}
