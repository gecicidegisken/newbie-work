using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeDatabase
{
    class Program
    {
       

        public  static void Main(string[] args)
        {  iscilersinifi iscilersinifi1 = new iscilersinifi("adi", "soyadi", 0);


            var isciListesi = new[]
               {
                new iscilersinifi("Bloom","Ateş",700),
                new iscilersinifi("Flora","Çiçek",550),
                new iscilersinifi("Stella","Güneş",600),
                new iscilersinifi("Musa","Müzik",400)

            };
            foreach (var item in isciListesi)
            {
                Console.WriteLine(item.isciismi + " " + item.iscisoyisimi + "  " + item.iscimaasi);
            }

           

            

                Console.ReadLine();
        }

      
        }
    }

