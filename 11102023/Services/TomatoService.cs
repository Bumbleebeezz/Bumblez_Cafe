using _11102023.Models;

namespace _11102023.Services;

public class TomatoService
{
    public event Action<Ingredient> TomatoAdded;

    public async Task AddTomato()
    {
        Console.WriteLine("Slicing tomato...");
        await Task.Delay(3000);
        var tomato = new Ingredient() { Name = "Tomato" };
        TomatoAdded.Invoke(tomato);
    }
}