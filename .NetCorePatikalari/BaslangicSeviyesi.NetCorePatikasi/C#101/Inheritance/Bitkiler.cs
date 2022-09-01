using System;

namespace Inheritance {
  public class Bitkiler:Canlilar
  {
    protected void Fotosentez()
    {
      Console.WriteLine("Bitkiler Fotosentez Yapar.");
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
    }
    public void SporlaCogalma()
    {
      Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır.");
    }
  }
}