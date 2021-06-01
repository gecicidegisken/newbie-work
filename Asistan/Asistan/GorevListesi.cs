using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Asistan
{
  public class GorevListesi //bu bir linked list 
    {
        private Gorev head=new Gorev();
        public UygunGorevlerStack UGStack = new UygunGorevlerStack();
            
        // DisplayList methodu listedeki tüm elemanları sırayla dolaşıp görüntülemek için bir listbox'a ekler
        public Gorev DisplayList(ListBox listbox)
        {
            listbox.Items.Clear();  // üstüne yazmasın diye listbox'u temizle

            Gorev current = head;    //root olan node'tan başla
            while (current.next != null) //sona gelene kadar
            {
                current = current.next; 
                listbox.Items.Add(current.isim);
                Debug.WriteLine(current.isim); //test
            }
            return current;
        }

        // listenin başına yeni görev (node) ekleyen method
        public void AddFirst(int sure, string isim)
        {
            Gorev yeniGorev = new Gorev(sure, isim);  //listenin başına bir node ekleniyor

            yeniGorev.next = head; // yeni eklenenin next pointerı artık headi gösteriyor ve head sonda kaldı
            head = yeniGorev; // "head" artık yeniGorev
        }

        //listenin sonuna node ekleme
        public void AddLast(int sure, string isim)
        {
            Gorev temp = head;  //geçici pointer
            Gorev yeniGorev = new Gorev(sure, isim); //yeni node için yer ayır

            while (temp.next != null)  //sona gelene kadar devam (traverse)
            {
                temp = temp.next;    //en sona geldiğinde temp.next null olacak
            }
            // ve buna next olarak yeni node ucuna eklenecek
            temp.next = yeniGorev;
       
        }

        //listeden gorev kaldıran method
        public void DeleteGorev(string toDelete)
        {
            Gorev temp = head;
            Gorev eski =null;

           
            while (temp != null && temp.isim != toDelete)  //silinecek node'a gelene kadar traverse
            {
                eski = temp;
                temp = temp.next;
            }
    
            //silinecek node = temp
            //temp'ten bi önceki node'un pointerı eski;
            //eski'yi temp'ten bi sonraki node'a yönlendiriyoruz
            //temp aradan çıkmış oluyor

            eski.next = temp.next;  
        
        }

        //listeyi traverse edip uygun görevleri stack'e push eden methods
        public void PushToStack(int sayac)
        {
            Gorev current = head;

            while (current.next != null) //sona gelene kadar

            {   current = current.next;

                if (current.sure <= sayac && Math.Abs(current.sure - sayac) <= 5)
                {
                    UGStack.Push(current.sure, current.isim);
                }
                
            }
        }


    }
}
