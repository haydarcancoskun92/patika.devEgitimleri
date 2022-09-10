using System;

namespace TelefonRehberiUygulamasi{
  
  public class Menus
  {
    PhoneBookOperations phoneBookOperations = new PhoneBookOperations();
    public int MakeMenu(string menuTitle, string menuSubtitle, string[] menuList)
    {
        int selection;
        Console.WriteLine(menuTitle.ToUpper());
        Console.WriteLine(menuSubtitle);
        for(int i=0; i<Math.Max(menuTitle.Length,menuSubtitle.Length);i++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
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

    public int MakeMenu(string[] menuList)
    {
        int selection;
        Console.WriteLine("");
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

    public int MakeMainMenu()
    {
      int selection;
      string[] MainMenuItems = {"Yeni Numara Kaydetmek","Varolan Numarayı Silmek","Varolan Numarayı Güncelleme","Rehberi Listelemek","Rehberde Arama Yapmak"};
      
      selection = MakeMenu("Telefon Rehberi Uygulaması",
                           "Lütfen yapmak istediğiniz işlemi seçiniz",
                            MainMenuItems);
      return selection;
    }

    public int MakeSubMenus(int selection)
    {
      switch(selection)
      {
        case 1:
          phoneBookOperations.AddPerson();
          break;
        case 2:
          phoneBookOperations.RemovePerson();
          break;
        case 3:
          phoneBookOperations.UpdatePerson();
          break;
        case 4:
          phoneBookOperations.PrintAllPeopleInfo();
          break;
        case 5:
          phoneBookOperations.SearchAndPrintPersonInfo();
          break;
      }
      return selection;
    }
  }
}