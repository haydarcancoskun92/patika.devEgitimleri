using System;

public class UcgenCizdirme

{

    public static void Main(string[] args)

    {

        Console.WriteLine("Çizilecek üçgen için taban değerini giriniz:");

        int length = Convert.ToInt32( Console.ReadLine());

        UcgenCiz(length);

    }

   

    public static void UcgenCiz(int length)

    {

        for(int i = length;i>0;i--)

        {

            for(int j=0; j<=length-i;j++)

            {

                Console.Write("*");

            }

            Console.WriteLine("");

           

        }

    }

}