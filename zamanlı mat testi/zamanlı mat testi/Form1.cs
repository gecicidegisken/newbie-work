using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zamanlı_mat_testi
{
    public partial class Form1 : Form
    {
        public int a;
        public int b;
        public int c,d;
        public int e1;
        public int f;
        public int k;
        public int l;
        int kalanZaman = 30;
        int sum;
        int sub;
        int div;
        int carp;

        public int sayisalla;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random sayisalla = new Random();
            a = sayisalla.Next(0, 100);
            b = sayisalla.Next(0, 100);
            c= sayisalla.Next(0, 100); 
            d= sayisalla.Next(0, 100);
            e1 = sayisalla.Next(0, 100);
            f = sayisalla.Next(1, 10);
            k = sayisalla.Next(2, 15);
            l = sayisalla.Next(2, 15);

            sum = a + b;
            sub = c - d;
            div = e1 / f;
            carp = k * l;

            label1.Text = (a) + "+" + (b) + "=";
            cikarma.Text =(c) + "-" + (d) + "=";
            carpma.Text = (k) + "x" + (l) + "=";
            bolme.Text = (e1) + "/" + (f) + "=";
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void cikarma_Click(object sender, EventArgs e)
        {

        }

        private void carpma_Click(object sender, EventArgs e)
        {

        }

        private void bolme_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalanZaman > 0)
            {

                kalanZaman = kalanZaman - 1;
                timeLabel.Text = "Kalan süre: " + kalanZaman + " saniye";
            }
            else
            {

                timer1.Stop();
                timeLabel.Text = "Süre bitti!";
                MessageBox.Show("Zamanında bitiremedin.Tekrar dene!");
                
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLabel.Text = "Kalan süre: " + kalanZaman + " saniye";
            timer1.Start();
            startButton.Visible = false;
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void toplasayac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cikarsayac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bolmesayac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (sum == toplasayac.Value)
                checkBox1.Checked = true;
            else { 
                checkBox1.Checked = false;
                 checkBox1.Text="Yanlış";
            }

            if (sub == cikarsayac.Value)
                checkBox2.Checked = true;
            else { 
                checkBox2.Checked = false;
              checkBox2.Text = "Yanlış";
            }

            if (div == bolmesayac.Value)
                checkBox4.Checked = true;
            else { 
                checkBox4.Checked = false;
                checkBox4.Text = "Yanlış";
            }
            if (numericUpDown4.Value==carp)
                checkBox3.Checked = true;
            else { 
                checkBox3.Checked = false;
                checkBox3.Text = "Yanlış";
        
            }

            if(checkBox1.Checked==true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
            {
                MessageBox.Show("TEBRİKLER!!! :)");
            }
            tekrarbutonu.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tekrarbutonu_Click(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          

        }
    }
}



