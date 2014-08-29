using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public abstract string Description();
        public abstract double Cost();
    }
}
