using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    class Rubber:Duck
    {
        public Rubber()
        {
            this.name = "Rubber duck";
            this.flyBehavior = new FlyNoWay();
        }
    }
}
