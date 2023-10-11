using _11102023.Models;

namespace _11102023.Services;

public class CheeseService
{
    public event Action<Ingredient> CheeseAdded;

    public async Task AddCheese()
    {
        Console.WriteLine("Carving cheese...");
        await Task.Delay(4000);
        var cheese = new Ingredient() { Name = "Cheese" };
        CheeseAdded.Invoke(cheese);
    }
}