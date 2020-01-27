using System;
using petstore.Models;

namespace petstore
{
  class Program
  {
    static void Main(string[] args)
    {
      PetStore petstore = new PetStore();
      Cat snibbley = new Cat("Mr.", "Snibbley");
      petstore.AddCatInventory(snibbley);
    }
  }
}
