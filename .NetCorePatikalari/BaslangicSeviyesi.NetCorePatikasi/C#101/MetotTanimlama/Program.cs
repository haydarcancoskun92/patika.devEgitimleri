﻿using System;
public class MetotTanimlama
{
    public static void Main(string[] args)
    {
        /*
        Erisim_belirteci geri_donustiği metot_adi(parametreListesi/Arguman)
        {
            Komutlar;
            return;
        }
        */

        int a = 2;
        int b = 3;

        Console.WriteLine(a + b);
        int sonuc = Topla(a, b);
        Console.WriteLine(sonuc);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));
        int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
        ornek.EkranaYazdir(sonuc2.ToString());
        ornek.EkranaYazdir(Convert.ToString(a + b));

    }
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int deger1, ref int deger2)
    {
        deger1++;
        deger2++;
        return (deger1 + deger2);
    }

}

