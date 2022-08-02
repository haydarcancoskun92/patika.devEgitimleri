using System;

 

public class TryCatchFinallyveMantıksalHatalar

{

    public static void Main(string[] args)

    {

        try

        {

            Console.WriteLine("Bir sayi giriniz");

            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girmiş olduğunuz sayi: "+sayi);

        } catch(Exception ex)

        {

            Console.WriteLine("Hata: "+ex.Message.ToString());

        }

        /*

        finally

        {

            Console.WriteLine("İşlem Tamamlandı.");

        }

        */

        try

        {

            //int a = int.Parse(null);

            //int a = int.Parse("Test");

            int a = int.Parse("9999999999999999999999999999999999999999999999999999999999999999");

        } catch(ArgumentNullException ex)

        {

            Console.WriteLine("Boş Değer Girdiniz.");

            Console.WriteLine(ex);

        }catch(FormatException ex)

        {

            Console.WriteLine("Veri Tipi Uygun Değil");

            Console.WriteLine(ex);

        }catch(OverflowException ex)

        {

            Console.WriteLine("Çok Büyük ya da Çok Küçük Bir Değer Girdiniz.");

            Console.WriteLine(ex);

        }

        finally

        {

            Console.WriteLine("İşlem Başarıyla Tamamlandı.");

        }

       

    }

}