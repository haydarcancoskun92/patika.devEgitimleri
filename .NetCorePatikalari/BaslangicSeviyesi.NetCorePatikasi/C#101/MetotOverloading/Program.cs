using System;

public class Program

{
    public static void Main()
    {
        //out parametreler
        string sayi = "999";
        bool sonuc = int.TryParse(sayi, out int outSayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }
        Metotlar instance = new Metotlar();
        instance.Topla(4, 5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Metot Aşırı Yükleme - Overloading
        int ifade = 999;
        instance.EkranaYazdır(Convert.ToString(ifade));
        instance.EkranaYazdır(ifade);
        instance.EkranaYazdır("Haydar Can", "Coşkun");
    }

}
class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdır(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdır(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdır(String veri1, String veri2)
    {
        Console.WriteLine(veri1 + " " + veri2);
    }

}