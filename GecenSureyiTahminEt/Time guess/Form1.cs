using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Time_guess
{   
    public partial class Form1 : Form
    {
        public static string baslamaZamani;
        public static string durmaZamani;
        public DateTime baslama;
        public DateTime durma;
        public int farks;

        Random sayisalla = new Random();

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(sayisalla.Next(5, 15));
            baslamaZamani = DateTime.Now.ToString("h:mm:ss tt");
            baslama = DateTime.Now;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            durma = DateTime.Now;
            durmaZamani = DateTime.Now.ToString("h:mm:ss:ss tt");
            label1.Text ="Baslama Zamani: " +baslamaZamani+"\n\n" + "Durma Zamanı: "+ durmaZamani;
            TimeSpan fark = durma - baslama;
            //if (fark > 1)
            //{
            //    label3.Text = "Başarısız!";
            //}
            //else
            //{
            //    label3.Text = "Başarılı!";
            //}
            label3.Text ="Süre:"+ Convert.ToString(fark);
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
