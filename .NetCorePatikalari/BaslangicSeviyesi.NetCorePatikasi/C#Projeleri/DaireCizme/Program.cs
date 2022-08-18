using System;

public class DaireCizme

{
    public static void Main(string[] args)
    {
        double radius;
        bool radiusControl;
        double deltaRadius = 0.4;
        double hip;

        Console.WriteLine("Yarıçap giriniz...");
        radiusControl = !double.TryParse(Console.ReadLine(), out radius) || radius < 0;

        while (radiusControl)
        {
            Console.WriteLine("Geçersiz değer girdiniz");
            Console.WriteLine("Tekrar deneyiniz");
            radiusControl = !double.TryParse(Console.ReadLine(), out radius) || radius < 0;
        }

        double rMin = radius - deltaRadius;
        double rMax = radius + deltaRadius;

        for (double i = radius; i >= -radius; i--)
        {
            for (double j = -radius; j <= radius; j++)
            {
                hip = Math.Pow(i, 2) + Math.Pow(j, 2);
                if (hip >= Math.Pow(rMin, 2) && hip <= Math.Pow(rMax, 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

    }

}