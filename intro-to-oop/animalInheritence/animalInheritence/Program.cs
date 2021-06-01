using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion aslan = new Lion("et", true, false, 7,"roar");  //false değerlerini true yaparsak fonksiyonların çevirdiği değer değişiyor
            Sheep koyun = new Sheep("ot", false, true, 3, "mee");

            Console.WriteLine("Lion");
            aslan.MakeNoise();
            aslan.Eat();
            aslan.Sleep(7);

            Console.WriteLine("\n\nSheep");

            koyun.MakeNoise();
            koyun.Eat();
            koyun.Sleep(3);
           


            Console.ReadLine();
        }
    }
}
