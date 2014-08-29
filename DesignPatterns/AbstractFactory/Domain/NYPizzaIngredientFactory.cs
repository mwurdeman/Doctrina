using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        IDough CreateDough()
        {
            throw new NotImplementedException();
        }

        ISauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        ICheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        List<IVeggie> CreateVeggies()
        {
            throw new NotImplementedException();
        }

        IPepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        IClam CreateClams()
        {
            throw new NotImplementedException();
        }
    }
}
