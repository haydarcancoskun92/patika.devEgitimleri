using System;
using System.Collections.Generic;

public class IntegerIkililerinToplami
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen n tane sayı giriniz... ");
        Console.WriteLine("Örnek: 12 14 2 2 4 5 ");
        int[] sayilar = Array.ConvertAll<String, int>(Console.ReadLine().Split(" "), int.Parse);
        Console.WriteLine("Sayıların ikili toplamı(Sayilar eşit ise toplamın karesi alınır): ");

        for (int i = 0; i < sayilar.Length; i += 2)
        {
            if (i + 1 < sayilar.Length)
            {
                if (sayilar[i] == sayilar[i + 1])
                {
                    Console.Write(Math.Pow(sayilar[i] * 2, 2) + " ");
                }
                else
                {
                    Console.Write(sayilar[i] + sayilar[i + 1] + " ");
                }
            }
        }
    }
}