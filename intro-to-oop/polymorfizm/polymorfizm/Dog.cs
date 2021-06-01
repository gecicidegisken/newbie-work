using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
    class Dog: Animal  // Animal classından INHERITANCE ile dog isminde bi child class oluşturduk
    {
       public string adi;
       public string neYer;
        public int omru;
        public bool uykuDurumu;
        public bool aclikDurumu;


        public Dog(string adi, string neYer, int omru, bool uykuDurumu, bool aclikDurumu) : base(adi, neYer, omru, uykuDurumu, aclikDurumu)
        {
            //CONSTRUCTOR 
        }

        public override void makeSound()   // virtual yerine override yazarak makeSound methodunu istediğimiz gibi kullanabiliyoruz.
        {
            Console.WriteLine("Dog says hav hav");
        }

        

    }
}
