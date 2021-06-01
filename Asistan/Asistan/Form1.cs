using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asistan
{
    public partial class Asistan : Form
    {
        GorevListesi list = new GorevListesi();
        public Asistan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { //linked listteki görevleri burda yaratılan listbox'ta sunacağız

            //Controls.Add(list.listbox);
            //list.listbox.Location = new System.Drawing.Point(10, 43);
            //list.listbox.Size = new System.Drawing.Size(268, 212);
            //list.listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        }

        private void addGorevBtn_Click(object sender, EventArgs e)
        {
            sureSayaci.Visible = true;
            GorevText.Visible = true;
            okBtn.Visible = true;
            label1.Visible = true;
            label6.Visible = true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            sureSayaci.Visible = false;
            GorevText.Visible = false; 
            okBtn.Visible = false;
            label1.Visible = false;
            label6.Visible = false;

            int s = Convert.ToInt32(sureSayaci.Value);
            string i = Convert.ToString(GorevText.Text);
           
            list.AddLast(s, i);  //istenilen görevi linked liste ekle
            list.DisplayList(listBox1); //debug & ekranda göster
            
        }

        private void DeleteGorevBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Silinecek görevi seçiniz.");
            }
            else
            {
                list.DeleteGorev(listBox1.SelectedItem.ToString()); //listeden sil

            }
            list.DisplayList(listBox1); //debug & listeyi ekranda göster
        }

        private void ShowGorevBtn_Click(object sender, EventArgs e)
        {    
            calismaSayaci.Visible = true;
            label5.Visible = true;
            ok2Btn.Visible = true;

            list.UGStack.Clear(); //Stack her seferinde sıfırlanıyor ki üstüne yazma olmasın
        }

        private void gecBtn_Click(object sender, EventArgs e)
        {
            //  geç denilirse en üstteki görevi stackten kaldır
            list.UGStack.Pop();

            //eğer tamamen boş kalmadıysa (stackte daha gorev varsa) sıradakini göster.
            if (list.UGStack.Peek() != null)
            {
                label4.Text = Convert.ToString(list.UGStack.Peek().sure) + " dakikada " + Convert.ToString(list.UGStack.Peek().isim);
            }
            else
            {
                label4.Text = "Bu sürede yapılacak \n başka görev kalmadı.";
                gecBtn.Visible = false;
            }        
        }

        private void ok2Btn_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label3.Visible = true;
            calismaSayaci.Visible = false;
            label5.Visible = false;
            ok2Btn.Visible = false;

            //linked list boyunca süreler istenilen süreyle uyuşursa stack'e push
            list.PushToStack(Convert.ToInt32(calismaSayaci.Value));

            // en üstteki görevi gör
            if (list.UGStack.Peek() != null)
            {
                label4.Text = Convert.ToString(list.UGStack.Peek().sure) + " dakikada " + Convert.ToString(list.UGStack.Peek().isim);
                gecBtn.Visible = true;
            }
            
        }

      
    }
}


//foreach (Gorev g in secretBox.Items)
//{
//    if (g.sure == calismaSayaci.Value)
//    {
//        stack.Push(g.sure, g.isim);
//    }
//}

//  DislplayList'in return methoduyla akalalı bir düzenleme lazım


//while (list.DisplayList() == null)
//{
//    if (list.DisplayList().sure == calismaSayaci.Value)
//    {
//        stack.Push(list.DisplayList().sure, list.DisplayList().isim);
//    }
//}