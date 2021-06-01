using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
 public  class Duck
    {
        public IFlyBehavior flyBehavior; //fly methodu bunun içinde
        public string name;
        public string Swim()
        {
            return "I can swim!";
        }
        
        public string Display()
        {
            return "I'm here! I am a "+ name +"!";
        }

        public string PerformFly()
        {
           return flyBehavior.Fly();  //yukarda tanımladığımız değişkenin Fly methodunu kullan.
        }
    }
}
