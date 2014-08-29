using BadExample.DomainLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadExample.ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPreferredCustomer = true;

            var service = new ProductService();
            var products = service.GetFeaturedProducts(isPreferredCustomer);
        }
    }
}
