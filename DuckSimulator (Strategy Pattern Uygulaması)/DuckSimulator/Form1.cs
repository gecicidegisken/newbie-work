using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckSimulator
{

    public partial class Form1 : Form
    {
        Duck activeduck;

        public Form1()
        {
            InitializeComponent();
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            activeduck = new RedHead();
        }

       

        private void MallardBtn_Click(object sender, EventArgs e)
        {
            activeduck = new Mallard();
        }

        private void rubberBtn_Click(object sender, EventArgs e)
        {
            activeduck = new Rubber();
        }

        private void decoyBtn_Click(object sender, EventArgs e)
        {
            activeduck = new Decoy();
        }
      //display ve swim için active ördek kontrolü yok
        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = activeduck.Display();
        }

        private void SwimBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = activeduck.Swim();
        } 
        private void FlyBtn_Click(object sender, EventArgs e)
        {
            if (activeduck == null)
            {
                textBox1.Text = "No ducks selected.";
            }
            else {
              textBox1.Text = Convert.ToString(activeduck.PerformFly());
          
 }
        }
    }
}
