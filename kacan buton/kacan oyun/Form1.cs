using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kacan_oyun
{
    public partial class beniyakala : Form
    {
        public beniyakala()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, EventArgs e)
        {

            Random sayisalla = new Random();
            int a, b;
            a = sayisalla.Next(1, 300);
            b = sayisalla.Next(1, 300);

            {
                button1.Location = new Point(a, b);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teşekkür ederiz :)");
        }
    }
}






