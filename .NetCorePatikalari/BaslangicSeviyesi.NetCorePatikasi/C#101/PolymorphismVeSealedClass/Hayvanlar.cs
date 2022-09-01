using System;

namespace Inheritance {
  public class Hayvanlar:Canlilar
  {
    protected void Adaptasyon()
    {
      Console.WriteLine("Hayvanlar Adapte Olabilir.");
    }

    public override void UyaranlaraTepki()
    {
      base.UyaranlaraTepki();
      Console.WriteLine("Hayvanlar Temasa Tepki Verir.");
    }
  }

  public class Surungenler:Hayvanlar
  {
    public Surungenler()
    {
      base.Beslenme();
      base.Solunum();
      base.Bosaltim();
      base.Adaptasyon();
      base.UyaranlaraTepki();
    }
    public void SurunerekHareketEtme()
    {
      Console.WriteLine("Sürüngenler Sürünerek Hareket Ederler.");
    }
  }

  public class Kuslar:Hayvanlar
  {
    public Kuslar()
    {
      base.Beslenme();
      base.Solunum();
      base.Bosaltim();
      base.Adaptasyon();
      base.UyaranlaraTepki();
    }
    public void Ucmak()
    {
      Console.WriteLine("Kuşlar Uçar.");
    }
  }
}