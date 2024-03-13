using System;

class Program
{
    static void Main(string[] args)
    {
        Complex a = new Complex(2, 2);
        Complex b = new Complex(1, 1);

        Console.WriteLine("a");
        a.Print();
        Console.WriteLine("b");
        b.Print();

        Complex s1 = a + b;
        Console.WriteLine("s1");
        s1.Print();

        Complex s2 = a - b;
        Console.WriteLine("s2");
        s2.Print();

        Complex s3 = a * b;
        Console.WriteLine("s3");
        s3.Print();

        Complex s4 = a / b;
        Console.WriteLine("s4");
        s4.Print();

        if (a == b)
            Console.WriteLine("Complex numbers are equal");
        else
            Console.WriteLine("Complex numbers are not equal");
    }
}

class Complex
{
    private double real;
    private double imag;

    public Complex(double real, double imag)
    {
        this.real = real;
        this.imag = imag;
    }

    public void Print()
    {
        Console.WriteLine($"({real}) + ({imag})i");
    }

    public double GetReal()
    {
        return real;
    }

    public double GetImaginary()
    {
        return imag;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        double sumReal = a.GetReal() + b.GetReal();
        double sumImaginary = a.GetImaginary() + b.GetImaginary();
        return new Complex(sumReal, sumImaginary);
    }

    public static Complex operator -(Complex a, Complex b)
{
    double diffReal = a.GetReal() - b.GetReal();
    double diffImaginary = a.GetImaginary() - b.GetImaginary();
    return new Complex(diffReal, diffImaginary);
}

public static Complex operator *(Complex a, Complex b)
{
    double prdReal = (a.GetReal() * b.GetReal()) - (a.GetImaginary() * b.GetImaginary());
    double prdImag = (a.GetReal() * b.GetImaginary()) + (a.GetImaginary() * b.GetReal());
    return new Complex(prdReal, prdImag);
}

public static Complex operator /(Complex a, Complex b)
{
    double divisor = b.GetReal() * b.GetReal() + b.GetImaginary() * b.GetImaginary();
    if (divisor == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }

    double divReal = (a.GetReal() * b.GetReal() + a.GetImaginary() * b.GetImaginary()) / divisor;
    double divImag = (a.GetImaginary() * b.GetReal() - a.GetReal() * b.GetImaginary()) / divisor;
    return new Complex(divReal, divImag);
}

public static bool operator ==(Complex a, Complex b)
{
    return a.real == b.real && a.imag == b.imag;
}

public static bool operator !=(Complex a, Complex b)
{
    return !(a == b);
}
}

