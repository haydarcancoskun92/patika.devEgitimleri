using System;
using System.Collections.Generic;

public class KarakterDegistirme
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Cümle Giriniz...");
        char first;
        char last;
        string result;
        string[] stringArr = Console.ReadLine().Split(" ");
        foreach (var item in stringArr)
        {
            if (item.Length > 1)
            {
                first = item[0];
                last = item[item.Length - 1];
                result = string.Concat(last, item.Substring(1, (item.Length - 2)), first);
                Console.Write(result + " ");
            }

        }

    }
}