using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this._description = "Dark Roast";
        }

        public override string Description()
        {
            return this._description;
        }

        public override double Cost()
        {
            return 1.29;
        }
    }
}
