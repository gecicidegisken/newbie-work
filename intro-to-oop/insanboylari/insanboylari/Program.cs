using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insanboylari
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] boylar = { 100, 150, 200, 165, 175, 178, 186 };

            insanboylari boyobject = new insanboylari("Lakers", boylar);   // insanboylari classından 'boyobject' isminde bi nesne oluşturduk

            Console.WriteLine("Takımdakilerin boyları:");
            boyobject.boyYazdir();


            Console.ReadLine();
        }
    }
}
