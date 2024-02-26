using System;

class Program
{
    static void Main(string[] args)
    {
       
        Triangle myTriangle = new Triangle(3, 4, 5);

        //different from the other codes, here i reached the functions in console write line

        Console.WriteLine("Area of the triangle: " + myTriangle.GetArea());
        Console.WriteLine("Perimeter of the triangle: " + myTriangle.GetPerimeter());

       
    }
}


//different from the other codes, in this code my variables are double and i didn't mention the coordinate

class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle() { }

    public Triangle(double a, double b, double c)
    {
        if (a > 0)
            sideA = a;

        if (b > 0)
            sideB = b;

        if (c > 0)
            sideC = c;
    }

    public double GetArea()
    {
        // Heron's formula for calculating the area of a triangle
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public double GetPerimeter()
    {
        return sideA + sideB + sideC;
    }

    public bool SetSideA(double a)
    {
        if (a > 0)
        {
            sideA = a;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool SetSideB(double b)
    {
        if (b > 0)
        {
            sideB = b;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool SetSideC(double c)
    {
        if (c > 0)
        {
            sideC = c;
            return true;
        }
        else
        {
            return false;
        }
    }
}
