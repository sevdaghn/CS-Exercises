using System;

public static class Program
{
  
  //
public static void Main(string[] args) C# dilindeki bir ana metod imzasıdır. Bu metot, C# programlarının başlangıç noktasını belirtir. Bu metot, program çalıştırıldığında otomatik olarak çağrılır ve programın ana işlevselliğini içerir.

public: Ana metotun erişim düzeyini belirtir. public erişim belirteci, bu metoda her yerden erişilebileceği anlamına gelir.
static: Ana metotun bir sınıf metodu olduğunu belirtir. Yani, bu metot sınıfın bir örneği oluşturulmadan doğrudan çağrılabilir.
void: Ana metotun geri dönüş değerini belirtir. void, bu metotun herhangi bir değer döndürmediği anlamına gelir.
Main: Ana metotun adıdır.
string[] args: Ana metoda iletilebilecek argümanlar dizisini temsil eder. Program çalıştırılırken komut satırından veri almak için kullanılabilir.
Bu nedenle, public static void Main(string[] args) ifadesi, programın başlangıç noktasını belirleyen ve komut satırından gelen argümanları alabilen bir metodu tanımlar.

  
    public static void Main(string[] args)
    {
        Console.WriteLine("Arsa ve Tarla Fiyat Hesaplama");

        // Input for length
        Console.Write("Arsa ya da tarlanın uzunluğunu metre cinsinden girin: ");
        double length = Convert.ToDouble(Console.ReadLine());


//Console.ReadLine() kullanıcıdan bir girdi almak için kullanılan bir C# metodu. Bu metot, kullanıcıdan bir satır metin girmesini bekler ve girilen metni bir string olarak döndürür.

Convert.ToDouble() ise bir değeri double veri türüne dönüştürmek için kullanılan bir C# metodu. Bu metot, verilen bir string'i double veri türüne dönüştürür.

Yani, Convert.ToDouble(Console.ReadLine()), kullanıcıdan bir string girdi alır ve bu girdiyi double veri türüne dönüştürür. Bu sıklıkla, kullanıcıdan sayısal veri almak ve onu hesaplamalarda kullanmak için kullanılır.
  
        // Input for width
        Console.Write("Arsa ya da tarlanın genişliğini metre cinsinden girin: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate area
        double area = length * width;

        // Calculate perimeter
        double perimeter = 2 * (length + width);

        // Input for price per square meter
        Console.Write("Metrekare başına fiyatı girin (TL/m^2): ");
        double pricePerSquareMeter = Convert.ToDouble(Console.ReadLine());

        // Calculate total price
        double totalPrice = area * pricePerSquareMeter;

        // Output results
        Console.WriteLine($"Arsa ya da tarlanın çevresi: {perimeter} metre");
        Console.WriteLine($"Arsa ya da tarlanın alanı: {area} metrekare");
        Console.WriteLine($"Toplam fiyat: {totalPrice} TL");
    }
}
