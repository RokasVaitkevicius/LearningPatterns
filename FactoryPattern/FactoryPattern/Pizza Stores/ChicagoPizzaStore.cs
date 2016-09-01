using FactoryPattern.Pizzas;

namespace FactoryPattern.Pizza_Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStylePizza();
            }
            else return null;
        }
    }
}