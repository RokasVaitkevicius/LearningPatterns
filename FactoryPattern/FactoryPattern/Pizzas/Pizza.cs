using System;
using System.Collections.Generic;

namespace FactoryPattern.Pizzas
{
    public abstract class Pizza
    {
        public string Name;
        public string Dough;
        public string Sauce;

        public List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough");
            Console.WriteLine("Adding sauce...");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"    {topping}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}