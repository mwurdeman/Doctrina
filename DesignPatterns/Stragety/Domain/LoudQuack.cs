using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LoudQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "Quack!!!";
        }
    }
}
