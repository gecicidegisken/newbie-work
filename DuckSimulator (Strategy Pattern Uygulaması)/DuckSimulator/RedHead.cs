using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    class RedHead : Duck
    {
        public RedHead()  //RedHead'in uçma özelliğini vermek için constructor.
        {
            this.name = "Redhead Duck";
            this.flyBehavior = new FlyWithWings();
        }

    }

}
