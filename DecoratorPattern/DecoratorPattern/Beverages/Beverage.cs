namespace DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string GetDescription() => description;

        public abstract double Cost();
    }
}