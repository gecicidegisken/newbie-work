using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    class FlyNoWay:IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly :(";
        }
    }
}
