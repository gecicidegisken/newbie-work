using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mahalle
    {
         public string sokak;  // NEDEN PUBLİC?   
         public int kapiNo;      // CÜNKÜ PUBLİC OLDUĞU İÇİN ERİŞİP DÜZENLEYEBİLİYORUZ

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mahalle ilkEv;           // mahalle class'inda ilkEv isimle nesne oluşturacağımızın belirteci
            ilkEv= new Mahalle();     // instabtiate (nesneyi olusturduk)
            Mahalle ikinciEv = new Mahalle();   // yukarda iki satırda yapılan işi tek satırda hallettik
            Mahalle sonEv = new Mahalle();

            ilkEv.kapiNo = 1;    // ilkev nesnesinin kapiNo property'si 
            ilkEv.sokak = "Çiçek";
            ikinciEv.kapiNo = 2;
            ikinciEv.sokak = "Böcek";
            sonEv.kapiNo = 3;
            sonEv.sokak = "Bal";
            Console.WriteLine("KANKYLER MAHALLESİ");
            Console.WriteLine("İlk evin adresi: " + ilkEv.sokak + " Sokak, No:" + ilkEv.kapiNo);
            Console.WriteLine("İkinci evin adresi: " + ikinciEv.sokak + " Sokak, No:" + ikinciEv.kapiNo);
            Console.WriteLine("Son evin adresi: " + sonEv.sokak + " Sokak, No:" + sonEv.kapiNo);

            System.Console.ReadKey();  // getch işini yapar


    }
}
}
    

