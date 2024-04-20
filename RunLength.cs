using System;

class MainClass {

  public static string RunLength(string str) {

    string compressed = "";
    int count = 1;

    for (int i = 0; i < str.Length; i++)
    {
        if (i + 1 < str.Length && str[i] == str[i + 1])
        {
            count++;
        }
        else
        {
            compressed += count.ToString() + str[i];
            count = 1; // Reset count for the next character
        }
    }

    return compressed;

  }

  static void Main() {  

    Console.WriteLine(RunLength(Console.ReadLine()));
    
  } 

}
