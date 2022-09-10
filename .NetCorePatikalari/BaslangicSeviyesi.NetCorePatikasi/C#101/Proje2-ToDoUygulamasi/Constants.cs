using System;
using System.Collections.Generic;

namespace ToDoUygulamasi {

  public static class Constants
  {
    public enum size { XS=1,S,M,L,XL};

    public enum boardStatus {TODO=1,INPROGRESS,DONE};
    
    private static List<Person> _people = new List<Person>();

    public static List<Person> People {get{return _people;}}
    
    static Constants()
    {
      dummyVariables();
    }
  
    public static void dummyVariables()
    {
      _people.Add(new Person("Ali","Coşkun",1));
      _people.Add(new Person("Yıldırım","Can",2));
      _people.Add(new Person("Feyyaz","Arslan",3));
      _people.Add(new Person("Fehmi","Arkan",4));
    }
  }
  
}