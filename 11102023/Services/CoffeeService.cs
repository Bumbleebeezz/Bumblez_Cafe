using _11102023.Models;

namespace _11102023.Services;

public class CoffeeService
{
    public event Action<Ingredient> CoffeeDone;

    public void PrepareCoffee()
    {
        Console.WriteLine("Coffee is brewing...");
        // Wait in milliseconds 
        Thread.Sleep(5000);
        var coffee = new Ingredient() { Name = "Coffee" };
        // Call out CoffeeDone
        CoffeeDone.Invoke(coffee);
    }
}