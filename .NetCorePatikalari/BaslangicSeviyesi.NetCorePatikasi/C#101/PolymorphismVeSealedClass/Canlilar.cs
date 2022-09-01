using System;

namespace Inheritance {
  // public sealed class Canlilar gibi olsaydı katılım engellenirdi.
  public class Canlilar
  {
    protected void Beslenme()
    {
      Console.WriteLine("Canlılar Beslenir.");
    }

    protected void Solunum()
    {
      Console.WriteLine("Canlılar Solunum Yapar.");
    }

    protected void Bosaltim()
    {
      Console.WriteLine("Canlılar Boşaltım Yapar.");
    }

    public virtual void UyaranlaraTepki()
    {
      Console.WriteLine("Canlılar Uyaranlara Tepki Verir.");
    }
  }
}