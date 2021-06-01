using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
  public interface IFlyBehavior
    {
        //IFlyBehavior Interface'ini implement eden diğer classlar (yani diğer uçma şekilleri) bu methodun içeriğini tanımlayacak
        string Fly();

        
    }
}
