using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insanboylari
{
  public  class insanboylari
    {
        int[] boylar;
        string takimAdi{get; set;}   //takim adını yazmamız gerek.

      public  insanboylari(string takimadi, int[] boydizisi)
        {
            takimAdi = takimadi;
            boylar = boydizisi;
        }

    public void boyYazdir()
        {
            for (int i = 0; i < boylar.Length; i++)
            {
                Console.WriteLine("{0}. Oyunucu: {1} cm",i+1,boylar[i]);
            }
        }
    }
}
