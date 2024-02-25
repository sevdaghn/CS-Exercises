

class daire
{
    private int yariCap;
    private int koordinat;
    private double pi = 3.14;

    public daire(){}

    public daire (int r, int k)
    {
        if ( r >= 0)
        yariCap = r;

        if (k >= 0)
        koordinat = k;
    }

    public double GetAlan ()
    {
        return pi * yariCap * yariCap;
    }

    public double GetCevre ()
    {
        return 2*pi*yariCap;
    }

    public bool SetKoord(int k)
{
    if (k >= 0)
    {
        koordinat = k;
        return true;
    }
    else
    {
        return false;
    }
}

public bool SetYaricap(int r)
{
    if (r >= 0)
    {
        yariCap = r;
        return true;
    }
    else
    {
        return false;
    }
}

    }

class Program
{
    static void Main(string[] args)
    {
     
        daire myCircle = new daire(5, 0); 


        double alan = myCircle.GetAlan();
        Console.WriteLine("Area of the circle: " + alan);

       
        double cevre = myCircle.GetCevre();
        Console.WriteLine("Circumference of the circle: " + cevre);
    }
}


