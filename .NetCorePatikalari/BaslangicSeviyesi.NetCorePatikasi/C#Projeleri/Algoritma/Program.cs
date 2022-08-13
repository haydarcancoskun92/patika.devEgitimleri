using System;

public class Algoritma
{
    public static void Main()
    {
        Console.WriteLine("Lütfen Metni Giriniz:");
        String text = Console.ReadLine();
        Console.WriteLine("Çıkarmak İstediğiniz Karakterin Pozisyonunu Giriniz:");

        int charPosition = int.Parse(Console.ReadLine());
        TextOperations textOperations = new TextOperations();
        text = textOperations.textRemover(text, charPosition);
        Console.WriteLine(text);
    }
}
class TextOperations

{
    public string textRemover(string text, int position)

    {
        if (position < text.Length)
        {
            return text.Remove(position - 1, 1);

        }
        else
        {
            return ("Karakter sınırını aştınız! \n" + text);
        }
    }

}