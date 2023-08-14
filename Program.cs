

using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

class Program
{
    private static Dictionary<string, string> Words = new Dictionary<string, string>()
    {

        { "i","я"   },
        {"we", "мы" },
        {"they", "они" },
        {"he", "он" },
        {"she", "она" }

    };

    public static string look()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, Words.Count);
        string randomKey = Words.Keys.ElementAt(randomIndex);
        string randomValue = Words[randomKey];
        return randomKey; // ?
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Учим английский");
        Console.WriteLine();


        bool exit = true;
        while (exit)
        {

            string randomWord = look();
            Console.WriteLine($"Какой перевод у слова ' {randomWord} '  ?"); ;

            string enterWord = Console.ReadLine();

            if (enterWord == "exit")
            {
                exit = false;
                break;
            }

            /*
             if (Words.ContainsKey(randomWord) == Words.ContainsValue(enterWord))
             {
                 Console.WriteLine("good!!!");
             }
            */
            if (Words[randomWord] == enterWord)
            {
                Console.WriteLine("good!!!");
            }
        }
    }
}