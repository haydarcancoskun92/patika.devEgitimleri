using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoUygulamasi
{
  public class BoardOperations
  {
    List<Person> personList = Constants.People;
    List<Board> boards = new List<Board>();
    
    public void AddCard()
    {
      Card card = new Card();   
      Console.WriteLine("Başlık Giriniz:");
      card.Title = Console.ReadLine();
      Console.WriteLine("İçerik Giriniz:");
      card.Content = Console.ReadLine();
      Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)");
      card.Size = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Kişi Giriniz:");
      Console.WriteLine("----------------------------");
      foreach(var person in personList)
      {
        Console.WriteLine(person.Name+" "+person.Surname+" "+" adlı kişinin ID'si: "+person.ID);
      }
      int personID = Convert.ToInt32(Console.ReadLine());
      Person searchedPerson = personList.SingleOrDefault(item => item.ID == personID);
      card.ResponsiblePerson = searchedPerson?.Name;
      boards.Add(new Board(Constants.boardStatus.TODO.ToString(),card,searchedPerson));
    }
    
  public void ListingBoards()
  {
    List<Board> boardLists = boards.Where(x=> x.Status == Constants.boardStatus.TODO.ToString()).ToList();
    Console.WriteLine("ToDo List");
    Console.WriteLine("********************");
    Detail(boardLists);

    boardLists = boards.Where(x=> x.Status == Constants.boardStatus.INPROGRESS.ToString()).ToList();
    Console.WriteLine("Inprogress List");
    Console.WriteLine("********************");
    Detail(boardLists);
    
    boardLists = boards.Where(x=> x.Status == Constants.boardStatus.DONE.ToString()).ToList();
    Console.WriteLine("Done List");
    Console.WriteLine("********************");
    Detail(boardLists);
 
  }
    public void Detail(List<Board> boardLists)
    {
      if(boardLists.Count==0)
      {
        Console.WriteLine("Listede kayıt bulanamadı.");
        Console.WriteLine("");
      }
      foreach(var board in boardLists)
    {
      Console.WriteLine("Başlık:" +board.Card.Title);
      Console.WriteLine("İçerik:" +board.Card.Content);
      Console.WriteLine("Atanan Kişi:" +board.Card.ResponsiblePerson);
      Console.WriteLine("Büyüklük:" +Enum.GetName(typeof(Constants.size), board.Card.Size));
      Console.WriteLine("");
      Console.WriteLine("-");
      Console.WriteLine("");
    }
    }

    public void Detail(Board board)
    {
      Console.WriteLine("Başlık:" +board.Card.Title);
      Console.WriteLine("İçerik:" +board.Card.Content);
      Console.WriteLine("Atanan Kişi:" +board.Card.ResponsiblePerson);
      Console.WriteLine("Büyüklük:" +Enum.GetName(typeof(Constants.size), board.Card.Size));
      Console.WriteLine("Line:" +board.Status);
      Console.WriteLine("");
      Console.WriteLine("-");
      Console.WriteLine("");
    }

    public void MoveCards()
    {
      Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:  ");
      string searchedTitle = Console.ReadLine();
      Console.WriteLine("");
      List<Board> searchedBoards = boards.Where(item => item.Card.Title == searchedTitle).ToList();

      if(searchedBoards.Count >1)
      {
        foreach( var board in searchedBoards)
        {
          Detail(board);
          Console.WriteLine("-----------------------");
          Console.WriteLine("");
          Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
          int selection = Convert.ToInt32(Console.ReadLine());
          board.Status = Enum.GetName(typeof(Constants.boardStatus),selection);
          Console.WriteLine("Başarıyla Taşındı.");
          Console.WriteLine("");
        }
      }else
      {
        TryAgainSelection(MoveCards);
      }
    }
    
  public void RemoveBoard()
  {
    
    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:");
    string searchedTitle = Console.ReadLine();
    Console.WriteLine("");
    
    List<Board> searchedBoards = boards.Where(item => item.Card.Title == searchedTitle).ToList();
    if(searchedBoards.Count >1)
    {
      Console.WriteLine("Silinen kayıt sayısı: " + searchedBoards.Count);
      Detail(searchedBoards);
      foreach(var board in searchedBoards)
      {
        boards.Remove(board);
      }
      Console.WriteLine("Silme işlemi başarılı!");
    }else
    {
      TryAgainSelection(RemoveBoard);
    }
  }

  public void TryAgainSelection(Action action)
  {
    string[] menuItems = {"* İşlemi sonlandırmak için : (1)", "* Yeniden denemek için : (2)"};
    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
      Menus menu = new Menus();
      int selection = menu.MakeMenu(menuItems);
      if(selection==1)
      {
        return ;
      }else
      {
        action();
      }
  }
  }
  
}