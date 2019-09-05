using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFacotry
{
    public class HamPizza : Pizza
    {
        public override string Prepare()
        {
            return "I am preparing a Ham pizza";
        }

        public override string Bake()
        {
            return "I am baking a Ham pizza";
        }

        public override string Box()
        {
            return "I am boxing a Ham pizza";
        }
    }
}