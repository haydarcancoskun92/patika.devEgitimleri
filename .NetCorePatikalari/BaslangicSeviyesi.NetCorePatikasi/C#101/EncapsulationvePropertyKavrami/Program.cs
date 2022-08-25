using System;

public class EncapsulationvePropertKavrami
{
    public static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayşe";
        ogrenci.Soyisim = "Yılmaz";
        ogrenci.OgrenciNo = 295;
        ogrenci.Sinif = 3;

        ogrenci.OgrenciBilgileriniGetir();

        ogrenci.SinifAtlat();
        ogrenci.OgrenciBilgileriniGetir();

        ogrenci.SinifDusur();
        ogrenci.OgrenciBilgileriniGetir();

        Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);

        ogrenci1.OgrenciBilgileriniGetir();
        ogrenci1.SinifDusur();
        ogrenci1.SinifDusur();
        ogrenci1.OgrenciBilgileriniGetir();
    }
}

class Ogrenci
{
    private string _isim;
    private string _soyisim;
    private int _ogrenciNo;
    private int _sinif;

    public string Isim { get => _isim; set => _isim = value; }
    public string Soyisim { get => _soyisim; set => _soyisim = value; }
    public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
    public int Sinif
    {
        get { return _sinif; }
        set
        {
            if (value <= 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir.");
                _sinif = 1;
            }
            else
            {
                _sinif = value;
            }

        }

    }

    public Ogrenci() { }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        this._isim = isim;
        this._soyisim = soyisim;
        this._ogrenciNo = ogrenciNo;
        this._sinif = sinif;
    }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***Öğrenci Bilgileri***");
        Console.WriteLine("Öğrenci Adı: " + this._isim);
        Console.WriteLine("Öğrenci Soyadı: " + this._soyisim);
        Console.WriteLine("Öğrenci No: " + this._ogrenciNo);
        Console.WriteLine("Öğrenci sınıfı: " + this._sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif++;
    }
    public void SinifDusur()
    {
        this.Sinif--;
    }
}