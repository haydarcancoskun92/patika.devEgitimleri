using System;
namespace ToDoUygulamasi {

  public class Person
  {
    private string _name;
    private string _surname;
    private int _id;

    public string Name { get {return _name;} set {_name = value;}}
    public string Surname { get {return _surname;} set {_surname = value;}}
    public int ID { get {return _id;} set {_id = value;}}

    public Person()
    {
      
    }
    
    public Person(string name, string surname, int id)
    {
      this._name = name;
      this._surname = surname;
      this._id = id;
    }
  }
}