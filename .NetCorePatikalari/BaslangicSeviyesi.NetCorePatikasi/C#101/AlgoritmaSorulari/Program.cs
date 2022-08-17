using System;

public class AlgoritmaSoruları

{
    public static void Main(string[] args)
    {
        MenuOperations menuOperations = new MenuOperations();
        string[] mainMenu = {

            "Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.",
            "Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.",
            "Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.",
            "Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.",

        };
        int selection = menuOperations.MakeMenu
        (
            "C#101 Algoritma Soruları Ödev 1",
            "Hesaplamak istediğiniz soruyu seçiniz...",
            mainMenu
        );

        menuOperations.QuestionCalculations(selection);
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

    public void QuestionCalculations(int selection)
    {
        InputOperations inputOperations = new InputOperations();
        switch (selection)
        {
            case 1:
                Console.WriteLine("***Çift Sayı Yazdırma***");
                Console.WriteLine("Pozitif bir sayi giriniz...");
                int n = inputOperations.IntegerTakeAndValidation();
                Console.WriteLine(n + " adet pozitif  sayi giriniz...");
                int[] arrayN = inputOperations.IntegerArrayTake(n);
                Console.WriteLine(n + " adet pozitif  sayi içerisinden çift olanlar:");
                inputOperations.modResultsWriting(arrayN, 2);
                break;
            case 2:
                Console.WriteLine("***Girilen Sayı İçin Bölüm Hesaplama***");
                Console.WriteLine("Pozitif iki sayi giriniz...");
                int n2 = inputOperations.IntegerTakeAndValidation();
                int m2 = inputOperations.IntegerTakeAndValidation();
                Console.WriteLine(n2 + " adet pozitif  sayi giriniz...");
                int[] arrayN2 = inputOperations.IntegerArrayTake(n2);
                Console.WriteLine(n2 + " adet pozitif  sayi içerisinden " + m2 + "'a/e/ye/ya tam bölünenler:");
                inputOperations.modResultsWriting(arrayN2, m2);
                break;
            case 3:
                Console.WriteLine("***Array Tersten Sıralama***");
                Console.WriteLine("Pozitif bir sayi giriniz...");
                int n3 = inputOperations.IntegerTakeAndValidation();
                Console.WriteLine(n3 + " adet kelime giriniz...");
                string[] arrayN3 = inputOperations.StringArrayTake(n3);
                Console.WriteLine("Sondan başa sıralı array:");
                inputOperations.ReverseArray(arrayN3);
                break;
            case 4:
                Console.WriteLine("***Kelime ve Harf Sayısı Hesaplama***");
                Console.WriteLine("Bir cümle yazınız");
                string s4 = inputOperations.StringTakeAndValidation();
                inputOperations.WordAndSyllableCounter(s4);
                break;
        }
    }

}

class InputOperations
{
    public int IntegerTakeAndValidation()
    {
        int inputInt;
        bool inputIntControl = !int.TryParse(Console.ReadLine(), out inputInt) || inputInt < 0;
        while (inputIntControl)
        {
            if (inputInt > 0)
            {
                break;

            }
            else if (inputInt < 0)
            {
                Console.WriteLine("This is not a positive integer");
            }
            else
            {
                Console.WriteLine("This is not a integer");
            }
            inputIntControl = !int.TryParse(Console.ReadLine(), out inputInt) || inputInt < 0;
        }
        return inputInt;

    }

    public int[] IntegerArrayTake(int sizeOfArray)
    {
        int[] intArray = new int[sizeOfArray];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = IntegerTakeAndValidation();
        }
        return intArray;
    }

    public void modResultsWriting(int[] array, int modulo)
    {
        foreach (var number in array)
        {
            if (number % modulo == 0 && modulo != 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    public string StringTakeAndValidation()
    {
        string inputString = Console.ReadLine();
        return inputString;
    }

    public string[] StringArrayTake(int sizeOfArray)
    {
        string[] stringArray = new string[sizeOfArray];
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = StringTakeAndValidation();
        }
        return stringArray;
    }

    public void ReverseArray(string[] array)
    {
        Array.Reverse(array);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

    }

    public void WordAndSyllableCounter(string input)
    {
        int wordCounter = 0;
        int syllableCounter = 0;
        string[] inputSplited = input.Split(" ");
        foreach (var word in inputSplited)
        {
            Console.WriteLine("*** {0} ***", word);
            Console.WriteLine("Harf Sayısı: " + word.Length);
            syllableCounter += word.Length;
            wordCounter++;
        }

        Console.WriteLine("*****Toplam***** ");
        Console.WriteLine("Toplam Harf Sayisi: " + syllableCounter);
        Console.WriteLine("Toplam Kelime Sayisi: " + wordCounter);
    }

}