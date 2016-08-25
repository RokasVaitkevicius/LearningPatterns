using StrategyPattern.Flights;
using StrategyPattern.Sounds;

namespace StrategyPattern.Ducks
{
    public abstract class Duck
    {
        public IQuack Quack;
        public IFly Fly;

        public abstract void Display();

        public void PerformQuack()
        {
            Quack.Quack();
        }

        public void PerformFly()
        {
            Fly.Fly();
        }

        public void SetFly(IFly fly)
        {
            this.Fly = fly;
        }

        public void SetQuack(IQuack quack)
        {
            this.Quack = quack;
        }

    }
}