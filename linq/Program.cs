using System;
using linq.services;

namespace linq
{
  class Program
  {
    static void Main(string[] args)
    {

    var repo = new IngredientRepository() ;
    Console.WriteLine(repo.GetbyId(1).Name);






      Console.Read();
    }
  }
}
