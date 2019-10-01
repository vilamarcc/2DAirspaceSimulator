using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Fondos : Form
    {
        int fondo;
        
        public Fondos()
        {
            InitializeComponent();
        }

        public int GetNum() //devolvemos el numero correspondiente al fondo que el usuario ha elegido
        {
            return fondo;
        }

        
        //Depende el fondo al que el usuario clique, el parámetro fondo varía su valor
        
        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox fondos = pictureBox1;
            fondo = 1;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox fondos = pictureBox2;
            fondo = 2;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox fondos = pictureBox3;
            fondo = 3;
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PictureBox fondos = pictureBox4;
            fondo = 4;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PictureBox fondos = pictureBox5;
            fondo = 5;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PictureBox fondos = pictureBox6;
            fondo = 6;
            Close();
        }
    }
}
