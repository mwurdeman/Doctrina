using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GoodExample.Domain
{
    public class ProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this._repository = repository;
        }

        public IEnumerable<DiscountedProduct> GetFeaturedProducts(IPrincipal user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            return from p in this._repository.GetFeaturedProducts()
                   select p.ApplyDiscountFor(user);
        }
    }
}
