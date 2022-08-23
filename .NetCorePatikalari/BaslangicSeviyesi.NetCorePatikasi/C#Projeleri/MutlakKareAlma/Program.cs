using System;
using System.Collections.Generic;

public class MutlakKareAlma
{
    public static void Main(string[] args)
    {
        int smallerIntegersSum = 0;
        int greaterIngegersSum = 0;
        int criticalValue = 67;
        Console.WriteLine("Lütfen n tane sayı giriniz... ");

        int[] sayilar = Array.ConvertAll<String, int>(Console.ReadLine().Split(" "), int.Parse);

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] < criticalValue)
            {
                smallerIntegersSum += criticalValue - sayilar[i];
            }
            else
            {
                greaterIngegersSum += Convert.ToInt32(Math.Pow((sayilar[i] - criticalValue), 2));
            }
        }
        Console.WriteLine(smallerIntegersSum + " " + greaterIngegersSum);

    }
}