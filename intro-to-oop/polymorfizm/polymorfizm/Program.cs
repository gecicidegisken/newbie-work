using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Dog kopek = new Dog("kopek","et",13,false,false);   // dog classından OBJECT (NESNE) üretmeden onu programda çağıramayız.
            kopek.makeSound();// kopekler hav hav der dicek çünkü override ettik bunu.
            kopek.yemekYe();
            kopek.uyu();


            Duck ordek = new Duck("ördek", "ot", 10, true, true);

            ordek.makeSound();
            ordek.yemekYe();
            ordek.uyu();
            
           
            Console.ReadLine();

        }
    }
}
