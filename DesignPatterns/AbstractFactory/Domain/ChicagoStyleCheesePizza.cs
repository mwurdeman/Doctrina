using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this._name = "Chicago Style Deep Dish Cheese Pizza";
            this._dough = "Extra Thick Crust Dough";
            this._sauce = "Plum Tomato Sauce";

            this._toppings.Add("Shredded Mozzarella Cheese");
        }

        public override string Cut()
        {
            return "Cutting Pizza into square slices";
        }
    }
}
