using System;

// Abstract class
public abstract class Animal
{
    // Abstract method
    public abstract void MakeSound();

    // Concrete method
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class Dog
public class Dog : Animal
{
    // Implementation of abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Derived class Cat
public class Cat : Animal
{
    // Implementation of abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound(); // Output: Woof!
        dog.Eat();       // Output: Animal is eating.

        cat.MakeSound(); // Output: Meow!
        cat.Eat();       // Output: Animal is eating.
    }
}
