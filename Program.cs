using System;

namespace Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient[] ingredients =
            {
            new Ingredient{Name = "Sugar", Calories=500},
            new Ingredient{Name = "Egg", Calories=100},
            new Ingredient{Name = "Milk", Calories=150},
            new Ingredient{Name = "Flour", Calories=50},
            new Ingredient{Name = "Butter", Calories=200}
            };
            Console.Read();
            
            foreach (var item in ingredients)
               {
                 System.Console.WriteLine($"name:{item.Name}");
               }
                  
        }
    }
}
