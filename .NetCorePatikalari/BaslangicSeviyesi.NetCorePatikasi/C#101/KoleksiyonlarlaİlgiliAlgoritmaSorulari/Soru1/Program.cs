using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberOfInput = 20;

        InputOperations inputOperations = new InputOperations();
        List<int> input = new List<int>();
        List<int> positiveNumbers = new List<int>();
        List<int> primeNumbers = new List<int>();

        Console.WriteLine("Lütfen 20 adet sayı giriniz...");
        for (int i = 0; i < numberOfInput; i++)
        {
            input.Add(inputOperations.IntegerTakeAndValidation());
        }
        positiveNumbers.AddRange(input);
        foreach (var item in input)
        {
            if (inputOperations.isPrime(item))
            {
                primeNumbers.Add(item);
                positiveNumbers.Remove(item);
            }
        }
        inputOperations.ShowListAverageAndListSize(positiveNumbers);
        inputOperations.ShowListAverageAndListSize(primeNumbers);
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

    public bool isPrime(int num)
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public void ShowListAverageAndListSize(List<int> list)
    {
        int sum = 0;
        foreach (var item in list)
        {
            Console.Write(item + " ");
            sum += item;
        }
        Console.WriteLine("Length of List: " + list.Count);
        Console.WriteLine("Average is " + (sum / list.Count));
    }

}