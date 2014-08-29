
using GoodExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodExample.UI.Models
{
    public class ProductViewModel
    {
        public ProductViewModel() { }

        public ProductViewModel(DiscountedProduct product)
        {
            this.Name = product.Name;
            this.UnitPrice = product.UnitPrice;
        }

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string SummaryText
        {
            get
            {
                return String.Format("{0} ({1:C})", this.Name, this.UnitPrice);
            }
        }
    }
}