using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Soy : CondimentDecorator
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost() => 0.15 + beverage.Cost();

        public override string GetDescription() => $"{beverage.GetDescription()}, Soy";
    }
}