using System;
using FactoryPattern.Pizzas;
using FactoryPattern.Pizza_Stores;

namespace FactoryPattern
{
    class Program
    {
        /// <summary>
        /// The Factory Method Pattern defines an interface
        /// for creating an object, but lets subclasses decide which 
        /// class to instantiate. Factory Method lets a class defer
        /// instantion to subclasses.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");
            Console.WriteLine();

            pizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}");
            Console.WriteLine();
        }
    }
}
