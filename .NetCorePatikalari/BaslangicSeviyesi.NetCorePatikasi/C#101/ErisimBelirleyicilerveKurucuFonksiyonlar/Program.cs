using System;

public class ErisimBelirleyiciveKurucuFonksiyonlar
{
    public static void Main(string[] args)
    {
        /*
        Söz Dizimi
        class SinifAdi
        {
            [Erişim Belirleyici] [Veri Tipi] özellikAdi;
            [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            {
                //Metot Gövdesi
            }
        }
       
        Erişim Belirleyiciler
         * Public
         * Private
         * Internal
         * Protected
        */

        Console.WriteLine("***Çalışan 1***");
        Calisan calisan1 = new Calisan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");
        //calisan1.ad = "Ayşe";
        //calisan1.soyad = "Kara";
        //calisan1.no = 23425634;
        //calisan1.departman = "İnsan Kaynakları";
        calisan1.CalisanBilgileri();

        Console.WriteLine("***Çalışan 2***");
        Calisan calisan2 = new Calisan();
        calisan2.ad = "Deniz";
        calisan2.soyad = "Arda";
        calisan2.no = 25646789;
        calisan2.departman = "Satın Alma";
        calisan2.CalisanBilgileri();
        Console.WriteLine("***Çalışan 3***");
        Calisan calisan3 = new Calisan("Haydar Can", "Coşkun");

        calisan3.CalisanBilgileri();
    }
}

class Calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {

        this.ad = ad;
        this.soyad = soyad;
        this.no = no;
        this.departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.ad = ad;
        this.soyad = soyad;
    }

    public Calisan()
    {

    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", ad);
        Console.WriteLine("Çalışanın soyadı:{0}", soyad);
        Console.WriteLine("Çalışanın numarası:{0}", no);
        Console.WriteLine("Çalışanın departmanı:{0}", departman);
    }
}