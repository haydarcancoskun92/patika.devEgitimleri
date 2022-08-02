using System;

public class OrtalamaHesaplama

{

    public static void Main(string[] args)

    {

        Console.WriteLine ("Fibonacci Serisi Ortalama Hesaplama");

        Console.WriteLine ("Kaçıncı Terime Kadar Hesaplamak İstiyorsunuz?");

        int lastTerm = Convert.ToInt32(Console.ReadLine());

        //Fibonacci Serisinin İlk iki sayısı sabit olarak alınıp, diğer sayılar türetilir. Bu yüzden ilk iki rakam sabit alınmıştır. Toplama işleminde karışıklık olmaması için ilk iki terimin toplamı sum değişkenine ilk değer olarak atanmıştır.

        int sum = 1;

        int firstTerm=0;

        int secondTerm=1;

        int nextTerm=0;

        for(int i= 3; i<lastTerm+1;i++)

        {

            nextTerm = firstTerm + secondTerm;

            Console.Write (nextTerm);

            firstTerm = secondTerm;

            secondTerm = nextTerm;

            sum +=nextTerm;

        }

        double avg = (double)sum/(double)lastTerm;

        avg = Math.Round(avg,2);

        Console.WriteLine ("İlk " + lastTerm+ " için toplam: "+sum +"'dir. Ortalama ise "+avg);

    }

}