using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int numberOfInput = 20;
        List<int> input = new List<int>();
        int[] maxNumbers = new int[3];
        int[] minNumbers = new int[3];
        int maxSum = 0;
        int minSum = 0;
        InputOperations inputOperations = new InputOperations();
        Console.WriteLine("Lütfen 20 adet sayı giriniz...");
        for (int i = 0; i < numberOfInput; i++)
        {
            input.Add(inputOperations.IntegerTakeAndValidation());
        }
        input.Sort();
        for (int i = 0; i < maxNumbers.Length; i++)
        {
            minNumbers[i] = input[i];
            minSum += input[i];
            maxNumbers[i] = input[input.Count - 1 - i];
            maxSum += input[input.Count - 1 - i];
        }

        Console.WriteLine("En küçük üç sayı");
        inputOperations.ResultShow(minNumbers, minSum);
        Console.WriteLine("En büyük üç sayı");
        inputOperations.ResultShow(maxNumbers, maxSum);
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

    public void ResultShow(int[] array, int sum)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("Sayıların Ortalaması: " + sum / array.Length);
    }
}

