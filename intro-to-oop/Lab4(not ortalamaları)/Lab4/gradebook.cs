using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class gradebook
    {
        private int[] notlar;  //ogrencilerin notlarını bu diziye giricez
        public string dersAdi { get; set; } //Dersin adı için property

        public gradebook(string name , int[] notdizisi)   //constructor 
        {
            notlar = notdizisi;
            dersAdi = name;
        }

        public void showMessage()
        {
            Console.WriteLine(dersAdi + " dersinin not sonuçları");

        }

        public void notlariYazdir()
        {
            for (int ogrenci = 0; ogrenci < notlar.Length; ++ogrenci)
                Console.WriteLine("Ogrenci {0}: {1}", ogrenci +1, notlar[ogrenci]);
        }

        public void ortalamaAl()
        {
            int sum = 0;
            for (int ogrenci = 0; ogrenci < notlar.Length; ogrenci++)
            {
                
                sum = sum + notlar[ogrenci];
               
            }
          int  avg = sum / notlar.Length;
            Console.WriteLine("Sınıfın not ortalaması: " + avg);
        }

        public void enDusukNot()
        {
            var minimum =
            from not in notlar
            orderby not
            select not;
           
            Console.WriteLine("En düşük not:" + minimum.First());
            
        }

        public void enYuksekNot()
        {
            var maksimum =
            from not in notlar
            orderby not descending
            select not;

            Console.WriteLine("En yüksek not:" + maksimum.First());

        }




        public void notIsleme()
        {

            notlariYazdir();
            ortalamaAl();
            enDusukNot();
            enYuksekNot();
        }
    }
}
