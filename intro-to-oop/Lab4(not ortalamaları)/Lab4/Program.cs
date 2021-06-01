using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
     
        static void Main(string[] args)
        {
           int[] notlar = {87,100,78,96, 59,40 };

            gradebook notdefteri = new gradebook("Algoritma", notlar);
            notdefteri.showMessage();
            notdefteri.notIsleme();
           
            Console.ReadLine();
        }
    }
}

