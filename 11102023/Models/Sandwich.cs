namespace _11102023.Models;

public class Sandwich
{
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public override string ToString()
    {
        var sandwichDescription = string.Empty;
        sandwichDescription += "The sandwich containes:\n";
        foreach (var sandwichIngredient in Ingredients)
        {
            sandwichDescription += $"\t{sandwichIngredient.Name}\n";
        }
        return sandwichDescription;
    }
}