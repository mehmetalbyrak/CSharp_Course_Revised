using System;

namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        //Intro();

        string sentence = "My name is Engin Demiroğ";
        
        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is Derin Demiroğ";
        Console.WriteLine(result); //24
        Console.WriteLine(result2);

        bool result3 = sentence.EndsWith("ğ");
        bool result4 = sentence.StartsWith("My name");

        var result5 = sentence.IndexOf("name");
        Console.WriteLine(result5); // 3

        var result6 = sentence.IndexOf(" ");
        Console.WriteLine(result6); // 2

        var result7 = sentence.LastIndexOf(" ");
        Console.WriteLine(result7); // 16 

        var result8 = sentence.Insert(0, "Hello, ");
        Console.WriteLine(result8); // Hello, My name is Derin Demiroğ

        var result9 = sentence.Substring(3,4);
        Console.WriteLine(result9); // name

        var result10 = sentence.ToLower();
        Console.WriteLine(result10); // my name is derin demiroğ
        
        var result11 = sentence.ToUpper();
        Console.WriteLine(result11); // MY NAME IS DERIN DEMIROĞ
        
        var result12 = sentence.Replace(" ", "-");
        Console.WriteLine(result12); // My-name-is-Derin-Demiroğ
        
        var result13 = sentence.Remove(12,6);
        Console.WriteLine(result13); // My name is Demiroğ


    }

    private static void Intro()
    {
        string city = "Ankara";
        //Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "İstanbul";
        //string result = city + city2;
        //Console.WriteLine(result);

        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}