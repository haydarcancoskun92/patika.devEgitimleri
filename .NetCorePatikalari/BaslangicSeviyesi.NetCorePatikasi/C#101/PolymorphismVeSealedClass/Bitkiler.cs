using System;

namespace Inheritance {
  public class Bitkiler:Canlilar
  {
    protected void Fotosentez()
    {
      Console.WriteLine("Bitkiler Fotosentez Yapar.");
    }

    public override void UyaranlaraTepki()
    {
      //base.UyaranlaraTepki();
      Console.WriteLine("Bitkiler Güneşe Tepki Verir.");
    }
  }

  public class TohumluBitkiler:Bitkiler
  {
    public TohumluBitkiler()
    {
      base.Beslenme();
      base.Solunum();
      base.Bosaltim();
      base.Fotosentez();
      base.UyaranlaraTepki();
    }
    public void TohumlaCogalma()
    {
      Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır.");
    }
  }

    public class TohumsuzBitkiler:Bitkiler
  {
    public TohumsuzBitkiler()
    {
      base.Beslenme();
      base.Solunum();
      base.Bosaltim();
      base.Fotosentez();
      base.UyaranlaraTepki();
    }
    public void SporlaCogalma()
    {
      Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır.");
    }
  }
}