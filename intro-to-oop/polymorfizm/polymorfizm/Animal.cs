using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
  public  class Animal   // This is the base class
    {

        public string adi;
        public string neYer;
        public int omru;
        public bool uykuDurumu;
        public bool aclikDurumu;

        public Animal(string adi, string neYer, int omru, bool uykuDurumu, bool aclikDurumu)
        {
            this.adi = adi;
            this.neYer = neYer;
            this.omru = omru;
            this.uykuDurumu = uykuDurumu;
            this.aclikDurumu = aclikDurumu;
        }  //CONSTRUCTOR 


        public void yemekYe()
        {
            if (aclikDurumu == false)
            {
                Console.WriteLine(neYer + " yedim.");
            }
            else
                Console.WriteLine("Karnım tok");

        }
        public void uyu()
        {
            if (uykuDurumu == true)
            {
                Console.WriteLine("Uyuyorum.");

            }
            else
                Console.WriteLine("uykum yok.");
            }
        public virtual void makeSound()      //virtual anahtar kelimesi polymorfizmi sağlayan şey. bunun sayesinde methodumuz çok biçimli olacak
        {
            Console.WriteLine("Animal makes a sound.");
        }

    }
}
