using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WoodDuck : Duck
    {
        public WoodDuck()
        {
            _quackBehavior = new MuteQuack();
        }
    }
}
