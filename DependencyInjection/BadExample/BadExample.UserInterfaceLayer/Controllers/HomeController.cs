using BadExample.DomainLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BadExample.UserInterfaceLayer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            bool isPreferredCustomer = this.User.IsInRole("PreferredCustomer");

            var service = new ProductService();
            var products = service.GetFeaturedProducts(isPreferredCustomer);
            this.ViewData["Products"] = products;

            return this.View(products);
        }

    }
}
