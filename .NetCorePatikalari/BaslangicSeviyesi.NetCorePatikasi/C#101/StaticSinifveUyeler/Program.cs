using System;

public class StaticSinifveUyeler
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ayşe", "Yılmaz", "İK");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan1 = new Calisan("Deniz", "Arda", "İK");
        Calisan calisan2 = new Calisan("Haydar Can", "Coşkun", "İK");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Console.WriteLine("Toplama İşlemi Sonucu {0}", Islemler.Toplam(100, 200));
        Console.WriteLine("Çıkarma İşlemi Sonucu {0}", Islemler.Cikarma(100, 200));
    }
}

class Calisan
{
    private static int _calisanSayisi;

    public static int CalisanSayisi { get => _calisanSayisi; }

    private string _isim;
    private string _soyisim;
    private string _departman;

    static Calisan()
    {
        _calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this._isim = isim;
        this._soyisim = soyisim;
        this._departman = departman;
        _calisanSayisi++;
    }
}

static class Islemler
{
    public static long Toplam(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cikarma(int sayi1, int sayi2)

    {
        return sayi1 - sayi2;
    }
}