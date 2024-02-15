using System;

public class Exercise2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Arsa ve Tarla Fiyat Hesaplama");
        
        double uzunluk = OlcuAl("uzunluk");
        double genislik = OlcuAl("genislik");
        double alan = AlanHesapla(uzunluk, genislik);
        double cevre = CevreHesapla(uzunluk, genislik);
        double metreKareBirimFiyat = MetreKareBirimFiyatAl();
        double toplamFiyat = ToplamFiyatHesapla(alan, metreKareBirimFiyat);
        
        Console.WriteLine($"Arsa ya da tarlanın çevresi: {cevre} metre");
        Console.WriteLine($"Arsa ya da tarlanın alanı: {alan} metrekare");
        Console.WriteLine($"Toplam fiyat: {toplamFiyat} TL");
    }
    
    public static double OlcuAl(string OlcuAdi)
    {
        Console.Write($"Arsa ya da tarlanın {OlcuAdi}ini metre cinsinden girin: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double AlanHesapla(double uzunluk, double genislik)
    {
        return uzunluk * genislik;
    }

    public static double CevreHesapla(double uzunluk, double genislik)
    {
        return 2 * (uzunluk + genislik);
    }

    public static double MetreKareBirimFiyatAl()
    {
        Console.Write("Metrekare başına fiyatı girin (TL/m^2): ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double ToplamFiyatHesapla(double alan, double metreKareBirimFiyat)
    {
        return alan * metreKareBirimFiyat;
    }
}
