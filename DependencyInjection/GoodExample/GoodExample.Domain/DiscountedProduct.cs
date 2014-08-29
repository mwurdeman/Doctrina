using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodExample.Domain
{
    public class DiscountedProduct
    {
        private readonly string _name;
        private readonly decimal _unitPrice;

        public string Name 
        { 
            get { return _name; } 
        }

        public decimal UnitPrice 
        { 
            get { return _unitPrice; } 
        }

        public DiscountedProduct(string name, decimal unitPrice)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            this._name = name;
            this._unitPrice = unitPrice;
        }
    }
}
