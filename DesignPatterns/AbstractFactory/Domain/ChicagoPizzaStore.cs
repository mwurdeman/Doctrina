﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else
            {
                return null;
            }
        }
    }
}
