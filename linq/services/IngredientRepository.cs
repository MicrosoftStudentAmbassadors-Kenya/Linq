using System.Linq;
using System.Collections.Generic;
namespace linq.services
{
  public class IngredientRepository :  IIngredients
  {
    private readonly List<Ingredient> _ingredient;
    public IngredientRepository()
    {
     _ingredient= new List<Ingredient>{
     new Ingredient{Id=1,Name = "Sugar", Calories=500},
     new Ingredient{Id=2,Name = "Egg", Calories=100},
     new Ingredient{Id=3,Name = "Milk", Calories=150},
     new Ingredient{Id=4,Name = "Flour", Calories=50},
     new Ingredient{Id=5,Name = "Butter", Calories=200}
     };
    }

    public bool Exist(int id)
    {
        return _ingredient.Any(i => i.Id == id);
    }

    public Ingredient GetbyId(int id)
    {
        if(Exist(id)){
            return _ingredient.FirstOrDefault(i => i.Id == id);
        }
      return null;
    }

    public Ingredient GetbyName(string name)
    {
      throw new System.NotImplementedException();
    }

    public Ingredient GetCaloriesGreaterthan50()
    {
      throw new System.NotImplementedException();
    }
  }
}