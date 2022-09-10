using System;
namespace ToDoUygulamasi {

  public class Card
  {
    private string _title;
    private string _content;
    private string _responsiblePerson;
    private int _size;

    public string Title { get {return _title;} set {_title = value;}}
    public string Content { get {return _content;} set {_content = value;}}
    public string ResponsiblePerson { get {return _responsiblePerson;} set {_responsiblePerson = value;}}
    public int Size { get {return _size;} set {_size = value;}}

    public Card()
    {
      
    }
    
    public Card (string title, string content, string responsiblePerson, int size)
    {
      this._title = title;
      this._content = content;
      this._responsiblePerson = responsiblePerson;
      this._size = size;
    }
  }
}