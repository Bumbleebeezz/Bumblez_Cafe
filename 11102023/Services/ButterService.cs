using _11102023.Models;

namespace _11102023.Services;

public class ButterService
{
    public event Action<Ingredient> ButterApplied;

    public async Task ApplyButter()
    {
        Console.WriteLine("Spreading butter...");
        await Task.Delay(5000);
        var butter = new Ingredient() {Name = "Butter"};
        ButterApplied.Invoke(butter);
    }
}