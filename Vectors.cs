using System;

public class Program
{
    public static void Main()
    {
        Vector Vector1 = new Vector(2, 4);
        Vector Vector2 = new Vector(3, 5);

        Vector resultAddition = Vector1 + Vector2;
        resultAddition.Print("Addition");

        Vector resultSubtraction = Vector1 - Vector2;
        resultSubtraction.Print("Subtraction");

        Vector resultMultiplication = Vector1 * Vector2;
        resultMultiplication.Print("Multiplication");

        Vector resultDivision = Vector1 / Vector2;
        resultDivision.Print("Division");
    }
}

public class Vector
{
    private double x;
    private double y;
    
    public Vector(){}
    
    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
    public void Print(string operation)
    {
        Console.WriteLine($"Vector 1 {operation} Vector 2 is equal to ({x}, {y})");
    }
    
    public double GetX()
    {
        return x;
    }
    
    public double GetY()
    {
        return y;
    }
    
    public static Vector operator +(Vector v1, Vector v2)
    {
        double newX = v1.GetX() + v2.GetX();
        double newY = v1.GetY() + v2.GetY();
        return new Vector(newX, newY);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        double newX = v1.GetX() - v2.GetX();
        double newY = v1.GetY() - v2.GetY();
        return new Vector(newX, newY);
    }

    public static Vector operator *(Vector v1, Vector v2)
    {
        double newX = v1.GetX() * v2.GetX();
        double newY = v1.GetY() * v2.GetY();
        return new Vector(newX, newY);
    }

    public static Vector operator /(Vector v1, Vector v2)
    {
        double newX = v1.GetX() / v2.GetX();
        double newY = v1.GetY() / v2.GetY();
        return new Vector(newX, newY);
    }
}
