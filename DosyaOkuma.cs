//deneme.txt diye ayrı bir dosyadan bilgiyi okuyacaktır.

StreamReader sr = File.OpenText("deneme.txt");

var s ="";

while ((s = sr.ReadLline()) != null)
{
   Console.WriteLine(sr.ReadLline()); 
}


//veya

string sonuc = File.ReadAllText("deneme.txt");
Console.WriteLine(sonuc); 


//okunacak sey eger dizi ise


string sonuc = File.ReadAllLines("deneme.txt");
Console.WriteLine(sonuc(0)); 
Console.WriteLine(sonuc(2)); 
