using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xonsolecalisma
{ 
   
    class Program
    { 
      static void Main(string[] args)
     {

            //önce bir array oluşturalım. var türünde oluşturuyoruz
            var sayilar = new[] { 1, 2, 3, 4, 9, 8, 7, 6, 5 };

            //şimdi ilk arrayı bi yazdıralım

            Console.WriteLine("Orijinal sayilar:");

            foreach (var element in sayilar)
                Console.Write($" {element}");  //writeline deyince alt alta yazıyor

            //şimdi LİNQ sorgusunu yapıcaz, 4'ten büyük sayıları yazdırıcaz.
            var dorttenbuyuk =
            from e in sayilar  // sayilar dizisi bizim data sourcemiz.  e ismini biz seçtik.
            where e > 4 
            select e;

            //şimdi yeni secilen sayıları yazıcaz
            Console.WriteLine("\n\n4'ten büyük sayılar:");

            foreach (var el in dorttenbuyuk) // secilenden almamız gerek
                Console.Write($" {el}");  // el ismini de kafama göre ben koydum.... 

            //şimdi orijinal listedekileri küçükten büyüğe dizelim

            var kucuktenbuyuge=
            from e in sayilar
            orderby e
            select e;

            Console.WriteLine("\n\nKüçükten büyüğe sayılar:");

            foreach (var item in kucuktenbuyuge)    //item ismi bize kalmış :( neden bilmiyorum :(
            {
                Console.Write($" {item}");
            }

            //bi de büyüktrn küçüğe yapalım

            var buyuktenkucuge =
              from eleman in sayilar
              orderby eleman descending
              select eleman;

            Console.WriteLine("\n\nBüyükten küçüğe sayılar:");
            foreach (var item in buyuktenkucuge)
            {
                Console.Write($" {item}");
            }
            
            // İKİ SORGUYU BERABER ÇALIŞTIRALIM

            //dörtten büyük sayıları, küçükten büyüğe sıralasın

            var dorttenbuyukkucuktenbuyuge=

                from e in dorttenbuyuk    // dorttenbuyuk önceden elimizde olmasaydı, from e in sayilar, where e>4 diye iki sorgu yapabilirdik
                orderby e
                select e;
            Console.WriteLine("\n\nBüyükten küçüğe dörtten büyük olan sayılar:");
            foreach (var item in dorttenbuyukkucuktenbuyuge)
            {
                Console.Write($" {item}");
            }
            Console.ReadLine();
     }
    }
}
