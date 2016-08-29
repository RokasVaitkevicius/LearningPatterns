using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Mocha : CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost() => 0.2 + beverage.Cost();

        public override string GetDescription() => $"{beverage.GetDescription()}, Mocha";
    }
}