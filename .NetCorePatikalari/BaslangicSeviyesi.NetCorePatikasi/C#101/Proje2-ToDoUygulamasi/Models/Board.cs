using System;
namespace ToDoUygulamasi {

  public class Board
  {
    private string _status;
    private Card _card;
    private Person _person;

    public string Status { get {return _status;} set {_status = value;}}
    public Card Card { get {return _card;} set {_card = value;}}
    public Person Person { get {return _person;} set {_person = value;}}
    
    public Board()
    {
      
    }

    public Board(string status, Card card, Person person)
    {
      this._status = status;
      this._card = card;
      this._person = person;
    }
    
  }
}