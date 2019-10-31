namespace linq.services
{
    public interface IIngredients
    {
       Ingredient GetbyId(int id);
       Ingredient GetbyName(string name);
       Ingredient GetCaloriesGreaterthan50();
       bool Exist(int a);
    }
}