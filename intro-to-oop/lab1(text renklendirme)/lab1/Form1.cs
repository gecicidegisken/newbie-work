using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)

        { Random sayisalla = new Random();

            int a = sayisalla.Next(0, 255);
            int b = sayisalla.Next(0, 255);
            int c = sayisalla.Next(0, 255);
           
            if (checkBox1.Checked == true) { 
                label1.BackColor = Color.FromArgb(a,b,c);
        }}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
