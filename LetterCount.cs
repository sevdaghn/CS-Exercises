using System;
using System.Linq;

class MainClass {

  public static string LetterCount(string str) {

    string[] words = str.Split(' ');
    string result = "-1";
    int maxCount = 0;

    foreach (string word in words)
    {
        int count = 0;
        foreach (char c in word)
        {
            if (word.Count(ch => ch == c) > 1)
            {
                count = word.Count(ch => ch == c);
                break;
            }
        }

        if (count > maxCount)
        {
            maxCount = count;
            result = word;
        }
    }

    return result;

  }

  static void Main() {  

    Console.WriteLine(LetterCount(Console.ReadLine()));
    
  } 

}
