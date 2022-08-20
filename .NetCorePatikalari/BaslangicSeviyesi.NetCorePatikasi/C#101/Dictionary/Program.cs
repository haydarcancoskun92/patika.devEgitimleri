using System;
using System.Collections.Generic;

public class Dictionary
{

    public static void Main(string[] args)
    {

        //System.Collections.Generic
        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

        kullanicilar.Add(10, "Ayşe Yılmaz");
        kullanicilar.Add(12, "Ahmet Yılmaz");
        kullanicilar.Add(18, "Deniz Arda");
        kullanicilar.Add(20, "Özcan Coşar");

        //Dictionary Elemanlarına Erişim
        Console.WriteLine("***Dictionary Elemanlarına Erişim***");
        Console.WriteLine(kullanicilar[12]);

        foreach (var kullanici in kullanicilar)
        {
            Console.WriteLine(kullanici);
        }

        //Count
        Console.WriteLine("***Count***");
        Console.WriteLine(kullanicilar.Count);

        //Contains
        Console.WriteLine("***Contains***");
        Console.WriteLine(kullanicilar.ContainsKey(12));
        Console.WriteLine(kullanicilar.ContainsValue("Haydar Can Coşkun"));

        //Remove
        Console.WriteLine("***Remove***");
        kullanicilar.Remove(12);

        foreach (var kullanici in kullanicilar)
        {
            Console.WriteLine(kullanici);
        }

        //Keys
        Console.WriteLine("***Keys***");

        foreach (var kullanici in kullanicilar.Keys)
        {
            Console.WriteLine(kullanici);
        }

        //Values
        Console.WriteLine("***Values***");

        foreach (var kullanici in kullanicilar.Values)
        {
            Console.WriteLine(kullanici);
        }

    }

}