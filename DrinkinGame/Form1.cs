using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkinGame
{
    public partial class Form1 : Form
    {
        PictureBox[] flechas;
        Random n1 = new Random();
        int n = 0;
        int m=0;

        public Form1()
        {
            InitializeComponent();
            flechas = new PictureBox[8];
            flechas[0] = pic1;
            flechas[1]= pic2;
            flechas[2]= pic3;
            flechas[3]= pic4;
            flechas[4] = pic5;
            flechas[5] = pic6;
            flechas[6] = pic7;
            flechas[7] = pic8;

        }

        private void BOTONGIRO_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;  
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {




            flechas[m].Visible = false;
            flechas[n].Visible = true;
            m = n;
            n = n1.Next(0, 8);
            while (n == m)
            {
                n = n1.Next(0, 8);
            };
            
            
            
            
        }
    }
}
