using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFacotry
{
    public abstract class Pizza
    {

        public virtual string Prepare()
        {
            return "I am preparing a pizza";
        }

        public virtual string Bake()
        {
            return "I am baking a pizza";
        }

        public virtual string Box()
        {
            return "I am boxing a pizza";
        }
    }
}