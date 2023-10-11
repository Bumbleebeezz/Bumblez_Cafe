using System.Transactions;
using _11102023.Handlers;
using _11102023.Services;


namespace _11102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffeeService = new CoffeeService();
            var milkService = new MilkService();
            var sugarService = new SugarService();
            var drinkHandler = new DrinkHandler(coffeeService, milkService, sugarService);

            coffeeService.PrepareCoffee();
            sugarService.AddSugar();
            milkService.AddMilk();
        }
    }
}