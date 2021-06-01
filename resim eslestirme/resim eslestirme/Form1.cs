using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resim_eslestirme
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        Random karistir = new Random(); //kutucuklara rastgele iconlar koyacağız

        List<string> icons = new List<string>()  // koyacağımız iconları temsil eden harfler. yazı fontu sayesinde farklı farklı görünüyorlar
        {
            "i","i","!","!","1","1","b","b","c","c","o","o","a","a","h","h"       };

        private void kutularaIconAta()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control kontrol in tableLayoutPanel1.Controls) //kontrol adında bi değişken oluşturduk. Control sınıfına ait
            {
                Label iconLabel = kontrol as Label; //iconlabel adındaki değişken bütün labelları kontrol ediyor
                if (iconLabel != null)
                {
                    int randomNumber = karistir.Next(icons.Count); //rastgele bi sayı ürettik
                    iconLabel.Text = icons[randomNumber];  // icon listesinden o sayı sırasındaki ögeyi çağırdık
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);

                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            kutularaIconAta(); // form yüklenir yüklenmez resimler görünsün diye fonksimizi çağırdık <3
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;

                }

            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /// This timer is started when the player clicks 
            /// two icons that don't match,
            /// so it counts three quarters of a second  (750 milisaniye)
            /// and then turns itself off and hides both icons

            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }
    }
}
