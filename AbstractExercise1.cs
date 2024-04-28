using System;

// Abstract class representing a geometric shape
public abstract class Shape
{
    // Abstract method for calculating area, must be implemented by derived classes
    public abstract double CalculateArea();
    
    // Concrete method to display a message
    public void DisplayMessage()
    {
        Console.WriteLine("This is a shape.");
    }
}

// Concrete class representing a rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Concrete class representing a circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of concrete classes
        Rectangle rectangle = new Rectangle(5, 4);
        Circle circle = new Circle(3);

        // Calling methods from abstract class
        rectangle.DisplayMessage();
        Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());

        circle.DisplayMessage();
        Console.WriteLine("Area of circle: " + circle.CalculateArea());
    }
}
