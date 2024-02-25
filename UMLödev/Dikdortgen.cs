class dikdortgen
{
    private int KisaKenar;
    private int UzunKenar;
    private int Koordinat;

    public dikdortgen () {}
    public dikdortgen (int a, int b, int k)
    {
        if ( a >= 0)
        KisaKenar = a;

        if ( b >= 0)
        UzunKenar = b;

        if ( k>= 0)
        Koordinat = k;
    }

    public int GetAlan ()
    {
        return UzunKenar * KisaKenar;
    }

    public int GetCevre ()
    {
        return (UzunKenar + KisaKenar)*2;
    }

    public bool SetUzunKenar(int b)
    {
        if (b >= 0)
        {
            UzunKenar = b;
            return true;
        }
        else
        {
            return false;
        }
    }

      public bool SetKisaKenar(int a)
    {
        if (a >= 0)
        {
            KisaKenar = a;
            return true;
        }
        else
        {
            return false;
        }
    }
      public bool SetKoordinat(int k)
    {
        if (k >= 0)
        {
            Koordinat = k;
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
     dikdortgen yeniDiktortgen = new dikdortgen(2,4,0);

    int alan = yeniDiktortgen.GetAlan();
    Console.WriteLine("Dikdörtgenin alanı: " + alan);

    int cevre = yeniDiktortgen.GetCevre();
    Console.WriteLine("Dikdörtgenin çevresi: " + cevre);
   }
}
