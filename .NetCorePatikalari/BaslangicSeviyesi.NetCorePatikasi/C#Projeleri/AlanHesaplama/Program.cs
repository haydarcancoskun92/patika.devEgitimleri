using System;

public class AlanHesaplama
{
    public static void Main(string[] args)
    {
        string[] geometricShapeMenuList = { "Daire", "Üçgen", "Kare", "Dikdörtgen" };
        string[] geometricPropertyMenuList = { "Çevre", "Alan", "Hacim" };

        MenuOperations GeometricShapeMenu = new MenuOperations();
        MenuOperations GeometricPropertyMenu = new MenuOperations();

        int shapeSelection = GeometricShapeMenu.MakeMenu(
            "*****Şekil Seçimi*****",
            "İşlem yapmak istediğiniz şeklin kodunu yazınız...",
            geometricShapeMenuList);
        int propertySelection = GeometricPropertyMenu.MakeMenu(
          "*****Özellik Seçimi*****",
          "İşlem yapmak istediğiniz özelliğin kodunu yazınız...",
          geometricPropertyMenuList);
        DataInputandCalculations(shapeSelection, propertySelection);
    }

    public static double[] DataInputandCalculations(int geometricShape, int geometricProperty)
    {
        InputOperations inputOperations = new InputOperations();
        double[] datas = new double[4];
        switch (geometricShape)

        {

            case 1:
                Console.WriteLine("Lütfen yarıçap giriniz...");
                datas[3] = inputOperations.DoubleTakeAndValidation();
                if (geometricProperty == 1)
                    Console.WriteLine("Daire için çevre: " + inputOperations.CevreHesaplama(datas[3]));
                if (geometricProperty == 2)
                    Console.WriteLine("Daire için alan: " + inputOperations.AlanHesaplama(datas[3]));
                if (geometricProperty == 3)
                    Console.WriteLine("Küre için hacim: " + inputOperations.HacimHesaplama(datas[3]));
                break;

            case 2:

                if (geometricProperty == 1)
                {
                    Console.WriteLine("Lütfen kenar uzunluklarını giriniz");
                    datas[0] = inputOperations.DoubleTakeAndValidation();
                    datas[1] = inputOperations.DoubleTakeAndValidation();
                    datas[2] = inputOperations.DoubleTakeAndValidation();
                    Console.WriteLine("Üçgen için çevre: " + inputOperations.CevreHesaplama(datas[0], datas[1], datas[2]));
                }

                if (geometricProperty == 2)
                {
                    Console.WriteLine("Lütfen taban uzunluğu giriniz...");
                    datas[0] = inputOperations.DoubleTakeAndValidation();
                    Console.WriteLine("Lütfen yükseklik giriniz...");
                    datas[1] = inputOperations.DoubleTakeAndValidation();
                    Console.WriteLine("Üçgen için alan: " + inputOperations.AlanHesaplamaUcgen(datas[0], datas[1]));
                }

                if (geometricProperty == 3)
                {
                    Console.WriteLine("Lütfen taban uzunluğu giriniz...");
                    datas[0] = inputOperations.DoubleTakeAndValidation();
                    Console.WriteLine("Lütfen taban yükseliğini giriniz...");
                    datas[1] = inputOperations.DoubleTakeAndValidation();
                    Console.WriteLine("Lütfen prizma yükseliğini giriniz...");
                    datas[2] = inputOperations.DoubleTakeAndValidation();
                    Console.WriteLine("Üçgen için alan: " + inputOperations.HacimHesaplamaUcgen(datas[0], datas[1], datas[2]));
                }
                break;

            case 3:
                Console.WriteLine("Lütfen kenar uzunluğu giriniz...");
                datas[0] = inputOperations.DoubleTakeAndValidation();

                if (geometricProperty == 1)
                {
                    Console.WriteLine("Kare için çevre: " + inputOperations.CevreHesaplama(datas[0], datas[0]));
                }

                if (geometricProperty == 2)
                {
                    Console.WriteLine("Kare için alan: " + inputOperations.AlanHesaplama(datas[0], datas[0]));
                }

                if (geometricProperty == 3)
                {
                    Console.WriteLine("Kare için hacim: " + inputOperations.HacimHesaplama(datas[0], datas[0], datas[0]));
                }
                break;

            case 4:

                Console.WriteLine("Lütfen kenar uzunluğu giriniz...");
                datas[0] = inputOperations.DoubleTakeAndValidation();
                Console.WriteLine("Lütfen kenar uzunluğu giriniz...");
                datas[1] = inputOperations.DoubleTakeAndValidation();
                Console.WriteLine("Lütfen yükseklik giriniz...");
                datas[2] = inputOperations.DoubleTakeAndValidation();

                if (geometricProperty == 1)
                {
                    Console.WriteLine("Dikdörtgen için çevre: " + inputOperations.CevreHesaplama(datas[0], datas[1]));
                }

                if (geometricProperty == 2)
                {
                    Console.WriteLine("Dikdörtgen için alan: " + inputOperations.AlanHesaplama(datas[0], datas[1]));
                }

                if (geometricProperty == 3)
                {
                    Console.WriteLine("Dikdörtgen için hacim: " + inputOperations.HacimHesaplama(datas[0], datas[1], datas[2]));
                }
                break;
        }
        return datas;
    }
}

class MenuOperations
{
    public int MakeMenu(string menuTitle, string menuSubtitle, string[] menuList)
    {
        int selection;
        Console.WriteLine(menuTitle.ToUpper());
        Console.WriteLine(menuSubtitle);

        for (int i = 0; i < menuList.Length; i++)
        {
            Console.WriteLine((i + 1) + " - " + menuList[i]);
        }
        Int32.TryParse(Console.ReadLine(), out selection);
        while (selection > menuList.Length || selection < 1)
        {
            Console.WriteLine("Geçersiz seçim yaptınız!!!");
            Console.WriteLine("Tekrar deneyiz...");
            Int32.TryParse(Console.ReadLine(), out selection);
        }
        return selection;
    }

}

class InputOperations

{
    public double DoubleTakeAndValidation()
    {
        double inputDouble;
        bool inputDoubleControl = !double.TryParse(Console.ReadLine(), out inputDouble);

        while (inputDoubleControl)
        {
            Console.WriteLine("This is not a valid input!");
            inputDoubleControl = !double.TryParse(Console.ReadLine(), out inputDouble);
        }
        return inputDouble;
    }

    public double[] DoubleArrayTake(int sizeOfArray)
    {
        double[] doubleArray = new double[sizeOfArray];

        for (int i = 0; i < doubleArray.Length; i++)
        {
            doubleArray[i] = DoubleTakeAndValidation();
        }
        return doubleArray;
    }

    public double CevreHesaplama(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public double CevreHesaplama(double a, double b, double c)
    {
        return a + b + c;
    }

    public double CevreHesaplama(double a, double b)
    {
        return 2 * (a + b);
    }

    public double AlanHesaplama(double radius)
    {
        return Math.PI * radius * radius;
    }

    public double AlanHesaplama(double a, double b)
    {
        return a * b;
    }

    public double AlanHesaplamaUcgen(double a, double b)
    {
        return a * b / 2;
    }

    public double HacimHesaplama(double radius)

    {
        return (4 / 3) * Math.PI * Math.Pow(radius, 3);
    }

    public double HacimHesaplama(double a, double b, double c)
    {
        return a * b * c;
    }

    public double HacimHesaplamaUcgen(double a, double b, double c)
    {
        return a * b / 2 * c;
    }

}