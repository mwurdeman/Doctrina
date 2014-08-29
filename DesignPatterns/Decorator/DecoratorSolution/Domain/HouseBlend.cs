using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this._description = "House Blend Coffee";
        }

        public override string Description()
        {
            return this._description;
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
