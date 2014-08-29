using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public string performQuack()
        {
            return _quackBehavior.Quack();
        }

        public string performFly()
        {
            return _flyBehavior.Fly();
        }

        public virtual string Display()
        {
            return "";
        }

        public string Swim()
        {
            return "All Ducks Swim"; 
        }
    }
}
