using System.Data;
using _11102023.Models;
using _11102023.Services;

namespace _11102023.Handlers;

public class DrinkHandler
{
    private readonly CoffeeService _coffeeService;
    private readonly MilkService _milkService;
    private readonly SugarService _sugarService;

    public Drink Drink { get;}

    // Dependancy injection 
    public DrinkHandler(CoffeeService coffeeService, MilkService milkService, SugarService sugarService)
    {
        _coffeeService = coffeeService;
        _milkService = milkService;
        _sugarService = sugarService;

        // Listen for event
        _coffeeService.CoffeeDone += CoffeeServiceOnCoffeeDone;
        _milkService.MilkAdded += MilkServiceOnMilkAdded;
        _sugarService.SugarAdded += SugarServiceOnCoffeeDone;
    }

    private void CoffeeServiceOnCoffeeDone(Ingredient coffee)
    {
        Drink.Ingredients.Add(coffee);
        Console.WriteLine("Coffee is done!");
    }

    private void MilkServiceOnMilkAdded(Ingredient milk)
    {
        Drink.Ingredients.Add(milk);
        Console.WriteLine("Milk added to coffee");
    }

    private void SugarServiceOnCoffeeDone(Ingredient sugar)
    {
        Drink.Ingredients.Add(sugar);  
        Console.WriteLine("Coffee is done!");
    }
}