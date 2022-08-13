using System;
public class KarakteriTerstenYazdirma

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Girdi bekleniyor...");
        String inputString = Console.ReadLine();
        StringOperations stringOperations = new StringOperations();
        stringOperations.FirstLetterToEnd(inputString);
    }
}

class StringOperations
{
    public string CharRemover(string input, int position)
    {
        if (position < input.Length)
        {
            input = input.Remove(position - 1, 1);
            return input;
        }
        else
        {
            return ("Karakter sınırını aştınız! \n" + input);
        }
    }
    public string StringFirstLetter(string input)
    {
        return input[0].ToString();
    }
    public void FirstLetterToEnd(string input)
    {
        string[] splitedInput = input.Split(' ');
        foreach (var splited in splitedInput)
        {
            Console.Write(string.Concat(CharRemover(splited, 1), StringFirstLetter(splited)) + " ");
        }
    }
}

