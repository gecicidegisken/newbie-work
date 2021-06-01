using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
  public class Duck: Animal
    {
       public Duck(string adi, string neYer, int omru, bool uykuDurumu, bool aclikDurumu) : base(adi, neYer, omru, uykuDurumu, aclikDurumu)
        {

        }


        public override void makeSound()
        {
            Console.WriteLine(adi+ " says vak vak");
        }
    }
}
