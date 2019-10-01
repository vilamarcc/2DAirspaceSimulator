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
    public partial class DecisionConflictos : Form
    {
        bool continuar;

        public DecisionConflictos()
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

        private void button1_Click(object sender, EventArgs e)//boton aceptar
        {
            ////El usuario quiere continuar con la simulación (necesitamos esté parámetro para pasarlo al form principal)
            this.continuar = true;

            //Cerramos este form
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //El usuario no quiere continuar con la simulación (necesitamos esté parámetro para pasarlo al form principal)
            this.continuar = false;

            //Si el usuario decide que prefiere comprobar conflictos antes de simular, le decimos que clique al botón "Conflictos"
            MessageBox.Show("Haz click en el botón 'Conflictos'");

            //Cerramos el form
            Close();
        }

        public bool GetContinuar() //Devuelve la decisión del usuario
        {
            return this.continuar;
        }
    }
}
