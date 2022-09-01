using System;

namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
                             Canlılar
                                |
                Bitkiler                  Hayvanlar
              |          |              |           |
            Tohumlu    Tohumsuz    Sürüngenler    Kuşlar
            */
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            //tohumluBitki.Beslenme();
            //tohumluBitki.Solunum();
            //tohumluBitki.Bosaltim();
            //tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("**********");
            Kuslar marti = new Kuslar();
            //marti.Beslenme();
            //marti.Solunum();
            //marti.Bosaltim();
            //marti.Adaptasyon();
            marti.Ucmak();
        }
    }
}