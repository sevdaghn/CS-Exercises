using System.Data;
using System.Diagnostics.CodeAnalysis;

class Kare 
{
    private int kenar;
    private int koordinat;

    public Kare (){}

    public Kare (int a, int k)
    {
        if (a >= 0)
        kenar = a;

        if (k >= 0)
        koordinat = k;
    }

    public int GetAlan ()
    {
        return kenar*kenar;
    }

    public int GetCevre ()
    {
        return kenar * 4;
    }

    public bool SetKenar(int a)
    {
        if(a >= 0)
        {
            kenar = a;
            return true;
        }
        else 
        {
            return false;
        }
    }

    public bool SetKoord (int k)
    {
        if ( k>= 0)
        {
            koordinat = k;
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
    static void Main (string[] args)
    {
        Kare yeniKare = new Kare(3,0);

        int alan = yeniKare.GetAlan();
        Console.WriteLine("Karenin alanı: " + alan);

        int cevre = yeniKare.GetCevre();
        Console.WriteLine("Karenin çevresi: " +cevre);
    }
}
