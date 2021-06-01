using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    class Mallard :Duck
    {
       public Mallard()
        {
            this.name = "Mallard";
            this.flyBehavior = new FlyWithWings();
        }
    }
}
