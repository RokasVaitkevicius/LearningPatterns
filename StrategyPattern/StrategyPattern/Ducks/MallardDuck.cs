using System;
using StrategyPattern.Flights;
using StrategyPattern.Sounds;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Fly = new FlyWithWings();
            Quack = new QuackAsRegular();
        }

        public override void Display()
        {
            Console.WriteLine("Oh a beautiful mallard duck!");
        }
    }
}