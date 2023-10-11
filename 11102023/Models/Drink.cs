using _11102023.Handlers;

namespace _11102023.Models;

public class Drink
{
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public override string ToString()
    {
        var drinkDescription = string.Empty;
        drinkDescription += "The drink containes:\n";
        foreach (var drinkIngredient in Ingredients)
        {
            drinkDescription += $"\t{drinkIngredient.Name}\n";
        }
        return drinkDescription;
    }
}