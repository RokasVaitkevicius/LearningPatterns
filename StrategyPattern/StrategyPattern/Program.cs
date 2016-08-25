using System;
using StrategyPattern.Ducks;
using StrategyPattern.Flights;

namespace StrategyPattern
{
    class Program
    {
		/** The Strategy Pattern defines a family of algorithms,
			encapsulates each one, and makes them interchangeable. 
			Strategy lets the algortihm vary independently from
			clients that use it. 
			
			In this case it allows to quickly add new properties 
			like allow different ducks to swim, each of them could
			swim differently and so on */
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();
            Console.WriteLine();

            var displayDuck = new DisplayDuck();
            displayDuck.Display();
            displayDuck.PerformFly();
            displayDuck.PerformQuack();
            Console.WriteLine();
            displayDuck.SetFly(new FlyWithWings());
            displayDuck.PerformFly();
        }
    }
}
