using _11102023.Models;

namespace _11102023.Services;

public class MilkService
{
    public event Action<Ingredient> MilkAdded;

    public void AddMilk()
    {
        Console.WriteLine("Pouring milk...");
        // Wait in milliseconds 
        Thread.Sleep(2000);
        // Object initalizer
        var milk = new Ingredient() {Name = "Milk"};
        // Call out CoffeeDone
        MilkAdded.Invoke(milk);
    }
}