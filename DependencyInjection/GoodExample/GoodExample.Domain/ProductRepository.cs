using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodExample.Domain
{
    public abstract class ProductRepository
    {
        public abstract IEnumerable<Product> GetFeaturedProducts();
    }
}
