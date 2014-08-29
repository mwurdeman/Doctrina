using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {

        }

        public override string Description()
        {
            return this._beverage.Description() + ", Soy";
        }

        public override double Cost()
        {
            return this._beverage.Cost() + .10;
        }
    }
}
