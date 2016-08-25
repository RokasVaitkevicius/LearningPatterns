using System;

namespace StrategyPattern.Sounds
{
    public class QuackAsRegular : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I believe i can quack!");
        }
    }
}