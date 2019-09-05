using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacotry
{
    public class PizzaStoreClass
    {
        private SimplePizzaFactory _factory;

        public PizzaStoreClass(SimplePizzaFactory pizzaFactory)
        {
            this._factory = pizzaFactory;

        }

        public Pizza orderPizza(PizzaType pizzaType)
        {
            Pizza pizza;
            pizza = _factory.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Box();

            return pizza;

        }
    }
}
