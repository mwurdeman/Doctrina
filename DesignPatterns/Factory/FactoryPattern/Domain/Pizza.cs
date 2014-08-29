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
        public string _dough;
        public string _sauce;
        public List<string> _toppings = new List<string>();

        public virtual string Prepare()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Preparing " + _name);
            sb.AppendLine("Tossing dough...");
            sb.AppendLine("Adding sauce...");
            sb.AppendLine("Adding toppings: ");
            
            foreach (string s in _toppings)
            {
                sb.AppendLine(s);
            }

            return sb.ToString();
        }

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
