using _11102023.Models;

namespace _11102023.Services;

public class SugarService
{
    public event Action<Ingredient> SugarAdded;

    public void AddSugar()
    {
        Console.WriteLine("Adding sugar...");
        // Wait in milliseconds 
        Thread.Sleep(1000);
        var sugar = new Ingredient() {Name = "Sugar"};
        // Call out CoffeeDone
        SugarAdded.Invoke(sugar);
    }
}