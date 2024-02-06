

StreamWriter sw = File.CreateText("deneme.txt");

    sw.WriteLine("merhaba");
    sw.WriteLine("deneme");
    sw.WriteLine("1");

sw.Close();


//veya daha hizli olan metod


using (StreamWriter sw = File.CreateText("deneme2.txt"))
{

    sw.WriteLine("merhaba");
    sw.WriteLine("deneme");
    sw.WriteLine("2");
}

//var olan dosyaya bilgi eklemek

using (StreamWriter sw = File.AppendText("deneme2.txt"))
{

    sw.WriteLine("selam");
    sw.WriteLine("deneme");
    sw.WriteLine("2");
}


using (StreamWriter sw = File.CreateText("deneme2.txt"))
{
    var s = "";
    
    while((s = sr.ReadLine)) != null)
    {
        Console.WriteLine(s);
    }
}

