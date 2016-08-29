using DecoratorPattern.Beverages;
using DecoratorPattern.Decorators;
using System;

namespace DecoratorPattern
{
    class Program
    {
        /// <summary>
        /// The Decorator Pattern attaches additional
        /// responsibilities to an object dynamically.
        /// Decorators provide a flixible alternative to
        /// subclassing for extending functionality.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} $ {beverage.Cost()}");

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} $ {beverage2.Cost()}");

        }
    }
}
