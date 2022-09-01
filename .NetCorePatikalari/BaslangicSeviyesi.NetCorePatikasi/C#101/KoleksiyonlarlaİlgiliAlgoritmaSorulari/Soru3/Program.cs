using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cümle İçerisindeki Sesli Harfleri Bulan Program");
        string input = Console.ReadLine().ToLower();

        vowelFinderAndShower(input);
    }

    public static void vowelFinderAndShower(string input)
    {
        string vowelString = "";
        //char[] vowels = {'a','e','ı','i','o','ö','u','ü'};
        string vowels = "aeıioöuü";
        string[] splittedInput = input.Split(" ");
        foreach (var item in splittedInput)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (vowels.Contains(item[i]))
                {
                    vowelString = string.Concat(vowelString, item[i].ToString());
                }
            }
            vowelString = string.Concat(vowelString, " ");
        }

        Console.WriteLine(input + " içindeki sesli harfler:");
        Console.WriteLine(vowelString);
    }
}

