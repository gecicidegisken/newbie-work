using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizm
{

    class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Hayvan sesi");
        }
        public void ozelSes()
        {
            makeSound();
        }

        protected void içSes()
        {
            Console.WriteLine("usul bir ses");
            bebekSesi();
        }

        public virtual void bebekSesi()
        {
            Console.WriteLine("Hayvan yavrusu sesi");
        }
    }

    class Dog:Animal
    {
        public Dog() //Constructor
        {

        }

        public override void makeSound()
        {
            Console.WriteLine("hav hav");
            içSes();
       }

        public override void bebekSesi()
        {
            Console.WriteLine("kopek yarvusunun sesi");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal köpüş = new Dog();
            köpüş.ozelSes();


            Dog karabaş = new Dog();
            karabaş.bebekSesi();
            

            Console.ReadKey();
        }
    }
}
