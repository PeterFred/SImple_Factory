using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFacotry
{
    public class FunghiPizza : Pizza
    {
        public override string Prepare()
        {
            return "I am preparing a Funghi pizza";
        }

        public override string Bake()
        {
            return "I am baking a Funghi pizza";
        }

        public override string Box()
        {
            return "I am boxing a Funghi pizza";
        }
    }
}