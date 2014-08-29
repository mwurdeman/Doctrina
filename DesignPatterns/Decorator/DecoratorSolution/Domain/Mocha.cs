using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {

        }

        public override string Description()
        {
            return base._beverage.Description() + ", Mocha";
        }

        public override double Cost()
        {
            return base._beverage.Cost() + .15;
        }
    }
}
