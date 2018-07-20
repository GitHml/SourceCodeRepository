using System;
using DecoratorPattern.Coffee;
using DecoratorPattern.Condiments;
using DecoratorPattern.Core;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} $ {beverage.Cost()}");

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.Description} $ {beverage2.Cost()}");


            Beverage beverage3 = new Espresso();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage2.Description} $ {beverage2.Cost()}");

        }
    }
}
