using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanClass;

namespace WindowsFormsApplication1
{
    public partial class Seguridad : Form
    {
        double dseg;
        double tciclo;

        public Seguridad()
        {
            InitializeComponent();
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

        public double GetDS()
        {
            return this.dseg;
        }

        public double Gettcliclo()
        {
            return this.tciclo;
        }

        private void button1_Click(object sender, EventArgs e)//insertamos los parametros introducidos como los de la distancia de seguridad y el tiempo de ciclo
        {

            try
            {
                this.dseg = Convert.ToDouble(distsegbox.Text);
                this.tciclo = Convert.ToDouble(tciclobox.Text);

                Close();
            }
            catch
            {
                MessageBox.Show("Error en el formato de los parámetros." +"\n"+"Por favor revisa los datos"+"\n");
            }
        }

        private void button2_Click(object sender, EventArgs e) //la distancia de seguridad y el tiempo de ciclo son los introducidos por el auto rellenar
        {
            distsegbox.Text = "50";
            tciclobox.Text = "1";
        }

    }
}
