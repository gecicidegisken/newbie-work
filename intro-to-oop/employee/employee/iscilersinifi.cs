using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeDatabase
{
    public class iscilersinifi
    {
        public string isciismi { get; }
        public string iscisoyisimi { get; }
        public decimal iscimaasi;


        public iscilersinifi(string isim, string soyisim, decimal maas)       // isci sınıfının yapıcı fonksiyonu??
        {
            isciismi = isim;
            iscisoyisimi = soyisim;
            iscimaasi = maas;
        }


    }
}

