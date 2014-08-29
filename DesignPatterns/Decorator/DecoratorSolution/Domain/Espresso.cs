using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this._description = "Espresso";
        }

        public override string Description()
        {
            return this._description;
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
