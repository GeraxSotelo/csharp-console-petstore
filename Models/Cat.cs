namespace petstore.Models
{
  class Cat
  {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string FullName
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }
    public int Lives { get; private set; }
    public bool Happy { get; set; }

    public Cat(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
      Lives = 9;
      Happy = false;
    }
  }
}