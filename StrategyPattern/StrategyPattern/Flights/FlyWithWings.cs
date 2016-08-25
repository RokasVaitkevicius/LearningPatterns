using System;

namespace StrategyPattern.Flights
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I fly using wings!");
        }
    }
}