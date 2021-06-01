using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    class Decoy:Duck
    {
        
        public Decoy()
        {
            this.name = "Decoy duck";
            this.flyBehavior = new FlyNoWay();
        }
    }
}
