using FactoryPattern.Pizzas;

namespace FactoryPattern.Pizza_Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStylePizza();
            }
            else return null;
        }
    }
}