using BadExample.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadExample.DomainLogicLayer
{
    public class ProductService
    {
        private readonly DependencyInjectionEntities context;

        public ProductService()
        {
            this.context = new DependencyInjectionEntities();
        }

        public IEnumerable<Product> GetFeaturedProducts(bool isCustomerPreferred)
        {
            var discount = isCustomerPreferred ? .95m : 1;
            var products = (from p in this.context.Products
                            where p.Featured
                            select p).AsEnumerable();

            return from p in products
                   select new Product
                   {
                      ProductID = p.ProductID,
                      Name = p.Name,
                      Description = p.Description,
                      Featured = p.Featured,
                      UnitPrice = p.UnitPrice * discount
                   };
        }
    }
}
