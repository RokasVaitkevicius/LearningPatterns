using System;

namespace StrategyPattern.Sounds
{
    public class QuackAsSqueek : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeek, squeek!");
        }
    }
}