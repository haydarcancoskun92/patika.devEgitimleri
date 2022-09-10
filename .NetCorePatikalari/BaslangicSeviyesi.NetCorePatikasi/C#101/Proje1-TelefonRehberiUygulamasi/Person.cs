namespace TelefonRehberiUygulamasi{
  public class Person
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    
    public string FirstName { get{return _firstName;}   set{this._firstName = value;} }
    public string LastName  { get{return _lastName;}    set{this._lastName = value;} }
    public string PhoneNumber  { get{return _phoneNumber;} set{this._phoneNumber = value;} }

    public Person()
    {

    }
    public Person(string firstName,string lastName,string phoneNumber)
    {
      this._firstName = firstName;
      this._lastName = lastName;
      this._phoneNumber = phoneNumber;
    }
  }
}