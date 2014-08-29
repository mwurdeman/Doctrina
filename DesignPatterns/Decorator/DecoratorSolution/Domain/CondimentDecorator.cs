using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double Cost()
        {
            return this._beverage.Cost();
        }

        public override string Description()
        {
            return this._beverage.Description();
        }
    }
}
