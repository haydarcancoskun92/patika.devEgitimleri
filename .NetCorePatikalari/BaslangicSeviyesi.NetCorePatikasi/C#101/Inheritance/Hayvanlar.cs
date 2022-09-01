using System;

namespace Inheritance {
  public class Hayvanlar:Canlilar
  {
    protected void Adaptasyon()
    {
      Console.WriteLine("Hayvanlar Adapte Olabilir.");
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
    }
    public void Ucmak()
    {
      Console.WriteLine("Kuşlar Uçar.");
    }
  }
}