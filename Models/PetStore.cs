using System;
using System.Collections.Generic;

namespace petstore.Models
{
  class PetStore
  {
    public List<Cat> Cats { get; private set; } = new List<Cat>();


    public void AddCatInventory(Cat cat)
    {
      Cats.Add(cat);
    }
  }
}