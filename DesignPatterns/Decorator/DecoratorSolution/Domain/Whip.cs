using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {

        }

        public override string Description()
        {
            return this._beverage.Description() + ", Whip";
        }

        public override double Cost()
        {
            return .05 + this._beverage.Cost();
        }
    }
}
