using System;

namespace ToDoUygulamasi {

  public class Menus
  {
    BoardOperations boardOperations = new BoardOperations();
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
      string[] MainMenuItems = {"Board Listelemek","Board'a Kart Eklemek","Board'dan Kart Silmek","Kart Taşımak"};
      
      selection = MakeMenu("ToDo List Uygulaması",
                           "Lütfen yapmak istediğiniz işlemi seçiniz",
                            MainMenuItems);
      return selection;
    }

    public int MakeSubMenus(int selection)
    {
      switch(selection)
      {
        case 1:
          boardOperations.ListingBoards();
          break;
        case 2:
          boardOperations.AddCard();
          break;
        case 3:
          boardOperations.RemoveBoard();
          break;
        case 4:
          boardOperations.MoveCards();
          break;

      }
      return selection;
    }
  }
}