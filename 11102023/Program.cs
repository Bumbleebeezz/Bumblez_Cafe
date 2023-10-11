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

            drinkHandler.PrepareDrink();

            Console.WriteLine(drinkHandler.Drink);



            var butterService = new ButterService();
            var cheeseService = new CheeseService();
            var tomatoService = new TomatoService();
            var sandwichHandler = new SandwichHandler(butterService, cheeseService, tomatoService);

            sandwichHandler.PrepareSandwich();

            Console.WriteLine(sandwichHandler.Sandwich);
        }
    }
}