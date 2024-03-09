using System;

namespace SinemaBileti
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sinema Bileti Satın Alma Makinesine Hoşgeldiniz!");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Hangi filmi izlemek istersiniz?");
            Console.WriteLine("Dune 2 (1)");
            Console.WriteLine("Anathomy of a fall (2)");
            Console.WriteLine("Kuru otlar üzerinde (3)");

            int choice = GetChoice(1, 3);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dune 2 seçildi. Kaç adet bilet istersiniz?");
                    break;
                case 2:
                    Console.WriteLine("Anathomy of a fall seçildi. Kaç adet bilet istersiniz?");
                    break;
                case 3:
                    Console.WriteLine("Kuru otlar üzerinde seçildi. Kaç adet bilet istersiniz?");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }

            int ticketCount = GetTicketCount();

            Console.WriteLine($"Toplam {ticketCount} adet bilet seçildi.");

            // Ödeme işlemi
            double totalPrice = CalculatePrice(choice, ticketCount);
            Console.WriteLine($"Toplam fiyat: {totalPrice} TL");

            // Sandalye sayısı kontrolü
            int availableSeats = GetAvailableSeats(choice);
            if (ticketCount > availableSeats)
            {
                Console.WriteLine($"Üzgünüz, sadece {availableSeats} koltuk kaldı.");
                Console.WriteLine("Lütfen tekrar deneyin.");
                return;
            }

            Console.WriteLine("Ödeme işlemi başarıyla tamamlandı. İyi seyirler!");
        }

        private static int GetChoice(int min, int max)
        {
            int choice;
            while (true)
            {
                Console.Write("Seçiminizi yapınız: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice >= min && choice <= max)
                        break;
                }
                Console.WriteLine("Geçersiz giriş! Lütfen tekrar deneyin.");
            }
            return choice;
        }

        private static int GetTicketCount()
        {
            int ticketCount;
            while (true)
            {
                Console.Write("Bilet adedi: ");
                if (int.TryParse(Console.ReadLine(), out ticketCount) && ticketCount > 0)
                    break;
                Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
            }
            return ticketCount;
        }

        private static double CalculatePrice(int movieChoice, int ticketCount)
        {
            double pricePerTicket;
            switch (movieChoice)
            {
                case 1:
                    pricePerTicket = 20.0; // Dune 2 fiyatı
                    break;
                case 2:
                    pricePerTicket = 15.0; // Anathomy of a fall fiyatı
                    break;
                case 3:
                    pricePerTicket = 10.0; // Kuru otlar üzerinde fiyatı
                    break;
                default:
                    return 0.0;
            }
            return pricePerTicket * ticketCount;
        }

        private static int GetAvailableSeats(int movieChoice)
        {
           
            // Varsayılan olarak 100 koltuk olduğunu varsayalım.
            int totalSeats = 100;
            // Bu örnekte, her film için 20 koltuk ayırdığımızı varsayalım.
            int seatsPerMovie = 20;

            // Şu an için sadece varsayılan değeri döndürelim.
            return totalSeats - movieChoice * seatsPerMovie;
        }
    }
}
