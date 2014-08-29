using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            this._name = "NY Style Sauce and Cheese Pizza";
            this._dough = "Thin Crust dough";
            this._sauce = "Marinara Sauce";

            this._toppings.Add("Grated Reggiano Cheese");
        }
    }
}
