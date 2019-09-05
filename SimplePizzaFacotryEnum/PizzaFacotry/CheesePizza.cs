using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFacotry
{
    public class CheesePizza : Pizza
    {

        public override string Prepare()
        {
            return "I am preparing a Cheese pizza";
        }

        public override string Bake()
        {
            return "I am baking a Cheese pizza";
        }

        public override string Box()
        {
            return "I am boxing a Cheese pizza";
        }
    }
}