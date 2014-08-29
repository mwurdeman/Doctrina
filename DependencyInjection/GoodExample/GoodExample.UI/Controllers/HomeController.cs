using GoodExample.Domain;
using GoodExample.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodExample.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly ProductRepository _repository;

        public HomeController(ProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this._repository = repository;
        }

        public ActionResult Index()
        {
            ProductService productService = new ProductService(this._repository);
            FeaturedProductsViewModel vm = new FeaturedProductsViewModel();

            var products = productService.GetFeaturedProducts(this.User);
            
            foreach (DiscountedProduct product in products)
            {
                ProductViewModel productVM = new ProductViewModel(product);
                vm.Products.Add(productVM);
            }

            return View(vm);
        }

    }
}
