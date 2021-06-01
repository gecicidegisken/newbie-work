using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistan
{ 
    // Linked list, "gorev" isimli node'lardan oluşacak.
    public class Gorev
    {
        public int sure;         
        public string isim;
        public Gorev next;

        public Gorev(int sure, string isim)
            {
                this.isim = isim;
                this.sure = sure;
                this.next = null;
            }
        public Gorev() {
            this.next = null;
        }
    }
}
