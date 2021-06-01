using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalInheritence
{
  public class Animal
    {
      protected string food;
      protected  bool hunger;
      protected string location;
      protected bool uykudurumu;
      protected int uykusaati;
       protected string ses;

        public Animal(string food, bool hunger, bool uykudurumu, int uykusaati,string ses)
        {
            this.food = food;
            this.hunger = hunger;
            this.uykudurumu = uykudurumu;
            this.uykusaati = uykusaati;
            this.ses = ses;
        }

     public void MakeNoise()
        {
            Console.WriteLine(ses);
        }

    public void Eat()
        { if (hunger == true)
                Console.WriteLine(food + " yendi");
            else
                Console.WriteLine("Aç değilim");
        }

    public void  Sleep(int uykusaati)  // günde kaç saat uyur
        {
            if (uykudurumu == true) 
           Console.WriteLine(uykusaati + " saat uyundu");

            else
              Console.WriteLine("Uykum yok.");  

       

        }

    }
}
