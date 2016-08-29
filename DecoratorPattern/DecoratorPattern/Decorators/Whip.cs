using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Whip : CondimentDecorator
    {
        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost() => 0.1 + beverage.Cost();

        public override string GetDescription() => $"{beverage.GetDescription()}, Whip";
    }
}