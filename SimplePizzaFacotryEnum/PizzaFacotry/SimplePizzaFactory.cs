namespace PizzaFacotry
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == PizzaType.Cheese)      pizza = new CheesePizza();
            else if (pizzaType == PizzaType.Funghi) pizza = new FunghiPizza();
            else if (pizzaType == PizzaType.Ham)    pizza = new HamPizza();
            return pizza;
        }
    }
}



