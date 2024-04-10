using System;

class Program
{
    static void Main(string[] args)
    {
        var soru1 = new Soru()
        {
            SoruMetni = "Hangisi programlama dili değildir?",
            Secenekler = new string[4] { "Python", "C#", "Java", "HTML" },
            Cevap = "HTML"
        };

        var soru2 = new Soru()
        {
            SoruMetni = "Hangisi en popüler programlama dilidir?",
            Secenekler = new string[4] { "Python", "C#", "Java", "HTML" },
            Cevap = "Python"
        };

        var soru3 = new Soru()
        {
            SoruMetni = "Hangisi en popüler web programlama platformu değildir?",
            Secenekler = new string[4] { "Django", "Asp.net", "Spring", "Python" },
            Cevap = "Python"
        };

        var sorular = new Soru[] { soru1, soru2, soru3 };

        foreach (var soru in sorular)
        {
            Console.WriteLine(soru.SoruMetni);
            foreach (var secenek in soru.Secenekler)
            {
                Console.WriteLine(secenek);
            }
            Console.Write("cevabınız:");
            var cevap = Console.ReadLine();

            if (soru.cevapKontrol(cevap))
            {
                Console.WriteLine("doğru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }
        }
    }
}

class Soru
{
    public string SoruMetni { get; set; }
    public string[] Secenekler { get; set; }
    public string Cevap { get; set; }

    public bool cevapKontrol(string cevap)
    {
        return this.Cevap.ToLower() == cevap.ToLower();
    }
}
