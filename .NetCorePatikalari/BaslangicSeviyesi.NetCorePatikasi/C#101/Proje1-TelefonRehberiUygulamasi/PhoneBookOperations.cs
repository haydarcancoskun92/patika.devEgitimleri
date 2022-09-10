using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberiUygulamasi{
  
  public class PhoneBookOperations
  {
    public static List<Person> people = new List<Person>();

    public void AddPerson()
    {
      Person person = new Person();

      Console.Write("Lütfen isim giriniz: ");
      person.FirstName = Console.ReadLine();
  
      Console.Write("Lütfen soyisim giriniz: ");
      person.LastName = Console.ReadLine();
  
      Console.Write("Lütfen telefon numarası giriniz: ");
      person.PhoneNumber = Console.ReadLine();

      people.Add(person);
      Console.WriteLine("-----Kayıt Başarılı-----");
      Console.WriteLine("");
    }

    public void RemovePerson()
    {
      Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
      string person = Console.ReadLine();
      if(SearchInPeople(person))
      {
        Person personToDelete = people.FirstOrDefault(item => item.FirstName == person || item.LastName == person);
          Console.WriteLine("{0} {1}  adlı kişi silindi.",personToDelete.FirstName,personToDelete.LastName);
          people.Remove(personToDelete);
       
      }
      Console.WriteLine("");
    }

    public void UpdatePerson()
    {
      Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
      string person = Console.ReadLine();
      if(SearchInPeople(person))
      {
        Person personToUpdate = people.FirstOrDefault(item => item.FirstName == person || item.LastName == person);
        Console.WriteLine("Yeni numarayı giriniz...");
        personToUpdate.PhoneNumber = Console.ReadLine();
        Console.WriteLine("{0} {1}  adlı kişinin numarası {2} olarak güncellendi. ",personToUpdate.FirstName,personToUpdate.LastName,personToUpdate.PhoneNumber);
        
        
      }
      Console.WriteLine("");
    }

    public bool SearchInPeople(string input)
    {
      bool result = false;
      while (!result){
        if(people.Exists(person=>person.FirstName == input) ||
           people.Exists(person=>person.LastName == input))
        {
          result = true;
          return result;
        }else
        {
          Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız...");
          string[] menuItems = {"* İşlemi sonlandırmak için : (1)","* Yeniden denemek için     : (2)"};
          Menus menu = new Menus();
          int selection = menu.MakeMenu(menuItems);
          if(selection == 1)
          {
            break;
            
          }else
          {
            result = false;
          }
          return result;
        }
      }
      return result;
    }

    public bool SearchPeopleInNumbers(string input)
    {
      bool result = false;
      while (!result){
        if(people.Exists(person=>person.PhoneNumber == input))
        {
          result = true;
          return result;
        }else
        {
          Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız...");
          string[] menuItems = {"* İşlemi sonlandırmak için : (1)","* Yeniden denemek için     : (2)"};
          Menus menu = new Menus();
          int selection = menu.MakeMenu(menuItems);
          if(selection == 1)
          {
            break;
            
          }else
          {
            result = false;
          }
          return result;
        }
      }
      return result;
    }

    public void PrintAllPeopleInfo()
    {
      if(people.Count==0)
      {
        Console.WriteLine("Telefon Rehberinde Kayıt Bulunamamıştır...");
      }else {
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("*************************");
        foreach(var person in people)
        {
          Console.WriteLine("İsim: "+person.FirstName);
          Console.WriteLine("Soyisim: "+person.LastName);
          Console.WriteLine("Numara: "+person.PhoneNumber);
          Console.WriteLine("*************************");
          Console.WriteLine("");
        }
      }
    }

    public void SearchAndPrintPersonInfo()
    {
      string person;
      string[] menuItems = {"İsim veya soyisime göre arama yapmak için: (1)","Telefon numarasına göre arama yapmak için: (2)"};
      
      Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
      Menus menu = new Menus();
      int selection = menu.MakeMenu(menuItems);
      if(selection == 1)
      {
        Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz: ");
        person = Console.ReadLine();
        if(SearchInPeople(person))
        {
          foreach(var item in people)
          {
            if(item.FirstName == person|| item.LastName == person)
            {
              Console.WriteLine("İsim: "+item.FirstName);
              Console.WriteLine("Soyisim: "+item.LastName);
              Console.WriteLine("Numara: "+item.PhoneNumber);
              Console.WriteLine("*************************");
              Console.WriteLine("");
            }
          }
          
        }
      }else
        {
          Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin numarasını giriniz: ");
          person = Console.ReadLine();
          if(SearchPeopleInNumbers(person))
          {
            foreach(var item in people)
            {
              if(item.PhoneNumber == person)
              {
                Console.WriteLine("İsim: "+item.FirstName);
                Console.WriteLine("Soyisim: "+item.LastName);
                Console.WriteLine("Numara: "+item.PhoneNumber);
                Console.WriteLine("*************************");
                Console.WriteLine("");
              }
            }
          }
        }
      }
    }
  }
