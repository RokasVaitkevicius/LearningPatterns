using System;
using StrategyPattern.Flights;
using StrategyPattern.Sounds;

namespace StrategyPattern.Ducks
{
    public class DisplayDuck : Duck
    {
        public DisplayDuck()
        {
            Fly = new FlyWithRocket();
            Quack = new QuackAsSqueek();
        }

        public override void Display()
        {
            Console.WriteLine("I just show myself, on display!");
        }
    }
}