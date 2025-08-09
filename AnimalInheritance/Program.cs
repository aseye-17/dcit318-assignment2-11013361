// Base class Animal
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each class
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();
        
        // Call MakeSound() on each instance
        Console.WriteLine("Animal makes sound:");
        genericAnimal.MakeSound();
        
        Console.WriteLine("\nDog makes sound:");
        myDog.MakeSound();
        
        Console.WriteLine("\nCat makes sound:");
        myCat.MakeSound();
        
        // Demonstrate polymorphism
        Console.WriteLine("\nDemonstrating polymorphism:");
        Animal[] animals = new Animal[] { new Animal(), new Dog(), new Cat() };
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}
