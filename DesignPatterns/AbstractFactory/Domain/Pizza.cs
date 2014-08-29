using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Pizza
    {
        public string _name;
        private IDough _dough;
        private ISauce _sause;
        private List<IVeggie> _veggies;
        private ICheese _cheese;
        private IPepperoni _pepperoni;
        private IClam _clam;

        public abstract string Prepare();

        public virtual string Bake()
        {
            return "Bake for 25 minute at 350";
        }

        public virtual string Cut()
        {
            return "Cutting the pizza into diagonal slices";
        }

        public virtual string Box()
        {
            return "Place pizza in official PizzaStore box";
        }

        public string GetName()
        {
            return _name;
        }
    }
}
