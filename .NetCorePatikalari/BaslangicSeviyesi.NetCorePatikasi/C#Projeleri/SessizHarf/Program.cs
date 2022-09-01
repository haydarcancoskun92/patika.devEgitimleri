using System;

public class SessizHarf
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Yanyana olan sesleri harfleri bulan program");
        string input = Console.ReadLine().ToLower();
        SequentialConsonantsFinderAndShower(input);
    }

    public static void SequentialConsonantsFinderAndShower(string input)
    {
        int consonantCounter = 0;
        bool twoConsonantTogether = false;
        string vowels = "aeıioöuü";
        string[] splittedInput = input.Split(" ");
        foreach (var item in splittedInput)
        {
            twoConsonantTogether = false;
            for (int i = 0; i < item.Length - 1; i++)
            {
                if (!vowels.Contains(item[i]) && !vowels.Contains(item[i + 1]))
                {
                    twoConsonantTogether = true;
                }

            }
            Console.WriteLine(item + ": " + twoConsonantTogether);
        }

    }

}