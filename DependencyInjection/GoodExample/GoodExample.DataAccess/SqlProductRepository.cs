using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodExample.DataAccess
{
    public class SqlProductRepository : Domain.ProductRepository
    {
        private readonly DependencyInjectionEntities context;

        public SqlProductRepository(string connectionString)
        {
            this.context = new DependencyInjectionEntities(connectionString);
        }

        public override IEnumerable<Domain.Product> GetFeaturedProducts()
        {
            throw new NotImplementedException();
        }
    }
}
