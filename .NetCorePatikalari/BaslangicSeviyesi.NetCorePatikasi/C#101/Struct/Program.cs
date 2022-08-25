using System;

public class Struct
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Mono World");
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.kisaKenar = 3;
        dikdortgen.uzunKenar = 4;
        Console.WriteLine("Class Alan Hesabı: " + dikdortgen.AlanHesapla());

        //DikdortgenStruct dikdortgenStruct = new DikdortgenStruct();
        //DikdortgenStruct dikdortgenStruct;
        //dikdortgenStruct.kisaKenar = 3;
        //dikdortgenStruct.uzunKenar = 4;
        DikdortgenStruct dikdortgenStruct = new DikdortgenStruct(3, 4);
        Console.WriteLine("Struct Alan Hesabı: " + dikdortgenStruct.AlanHesapla());
    }
}

class Dikdortgen
{
    public int kisaKenar;
    public int uzunKenar;

    public Dikdortgen()
    {
        kisaKenar = 3;
        uzunKenar = 4;
    }

    public long AlanHesapla()
    {
        return this.kisaKenar * this.uzunKenar;
    }

}

struct DikdortgenStruct
{
    public int kisaKenar;
    public int uzunKenar;

    public DikdortgenStruct(int kisaKenar, int uzunKenar)
    {
        this.kisaKenar = kisaKenar;
        this.uzunKenar = uzunKenar;
    }

    public long AlanHesapla()
    {
        return this.kisaKenar * this.uzunKenar;
    }
}