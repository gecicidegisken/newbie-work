using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistan
{
  public class UygunGorevlerStack
    {
        Gorev top;
        
        public UygunGorevlerStack()
        {
            this.top = null;
        }

        public void Push(int sure, string isim)
        {
            Gorev yeniGorev = new Gorev(sure,isim); //gorevin oluşturulacapğı boş Node

            if (top == null)       //eğer stack boşsa, yeni gorev "top" Node olur. ve next pointerı null işaret eder
            {
                yeniGorev.next = null;
            }
            else               //stack doluysa yeni gorevin nexti top ile bağlanır
            {
                yeniGorev.next = top;
            }
            top = yeniGorev;   // ve son eklenen node (yeniGorev) en başa gelmiş olur. (top altta kalır)
    
        }

        // Stack'in en üstündeki (top) node'u döndürür
        public Gorev Peek()
        {
            if (top == null)
            {
                MessageBox.Show("Uygun görev bulunamadı.");
                return null;
            }

            return top;
        }
        public void Pop()
        {
            if (top == null)
            {
                return;
            }
            // artık top node yok. Onun işaret ettiği (bir altındaki) node = top
            top = top.next;
        }

        public void Clear()
        {
            while(top != null)
            {
                Pop();
            }
        }
  }
}

