// Interface definition
interface IMovable
{
    void Move();
    string Name { get; }
}

// Car class implementing IMovable
class Car : IMovable
{
    public string Name => "Car";
    
    public void Move()
    {
        Console.WriteLine($"{Name} is moving on the road");
    }
    
    public void Honk()
    {
        Console.WriteLine("Honk! Honk!");
    }
}

// Bicycle class implementing IMovable
class Bicycle : IMovable
{
    public string Name => "Bicycle";
    
    public void Move()
    {
        Console.WriteLine($"{Name} is pedaling on the bike path");
    }
    
    public void RingBell()
    {
        Console.WriteLine("Ring! Ring!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Car and Bicycle
        Car myCar = new Car();
        Bicycle myBike = new Bicycle();
        
        // Call Move() on each instance
        Console.WriteLine("Direct method calls:");
        myCar.Move();
        myBike.Move();
        
        // Demonstrate polymorphism with interface
        Console.WriteLine("\nDemonstrating polymorphism with interface:");
        IMovable[] movables = new IMovable[] { myCar, myBike };
        
        foreach (var movable in movables)
        {
            Console.Write($"{movable.Name}: ");
            movable.Move();
            
            // Type checking and casting
            if (movable is Car car)
            {
                car.Honk();
            }
            else if (movable is Bicycle bike)
            {
                bike.RingBell();
            }
        }
        
        // Demonstrate interface as a parameter
        Console.WriteLine("\nDemonstrating interface as a parameter:");
        StartMoving(myCar);
        StartMoving(myBike);
    }
    
    // Method that accepts any IMovable object
    static void StartMoving(IMovable movable)
    {
        Console.Write($"Starting to move {movable.Name}: ");
        movable.Move();
    }
}
