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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            panelaura.BackgroundImage = Properties.Resources.laurafoto;
            panelmarc.BackgroundImage = Properties.Resources.marcfoto;
            panelsara.BackgroundImage = Properties.Resources.sarafoto;
            panelgorka.BackgroundImage = Properties.Resources.gorkafoto;
        }

        public void cambiarfondo(int fondo)
        {
            //Depende del número, se pondrá un fondo u otro

            if (fondo == 1)
            {
                this.BackgroundImage = Properties.Resources.background_airport;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 2)
            {
                this.BackgroundImage = Properties.Resources.nubes;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 3)
            {
                this.BackgroundImage = Properties.Resources.paisaje;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 4)
            {
                this.BackgroundImage = Properties.Resources.puesta_de_sol;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 5)
            {
                this.BackgroundImage = Properties.Resources.noche;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (fondo == 6)
            {
                this.BackgroundImage = Properties.Resources.aurora;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }



    }
}
