using System;

namespace StrategyPattern.Flights
{
    public class FlyWithRocket : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I fly using rocket!");
        }
    }
}