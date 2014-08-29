using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new LoudQuack();
            _flyBehavior = new FlyWithWings();
        }

        public override string Display()
        {
            return "I'm a mallard duck";
        }
    }
}
