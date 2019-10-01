using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FlightPlanClass;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class AñadirFP : Form
    {
        FlightPlan FP;

        public AñadirFP()
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

        public FlightPlan getflightdata ()
        {
            return this.FP;
        }

        private void button1_Click(object sender, EventArgs e) //insertamos el flight plan que hemos introducido manualmente
        {
            try
            {
                string id = IDbox.Text;
                string companyia = compbox.Text;
                double fx = Convert.ToDouble(xfinbox.Text);
                double fy = Convert.ToDouble(yfinbox.Text);
                double xi = Convert.ToDouble(xinbox.Text);
                double yi = Convert.ToDouble(yinbox.Text);
                double vel = Convert.ToDouble(vbox.Text);
                FP = new FlightPlan(id, companyia, vel, xi, yi, fx, fy);
                Close();
            }
            catch
            {
                MessageBox.Show("Error en el formato de los parámetros." + "\n" + "Por favor revisa los datos");
            }
        }

        private void button2_Click(object sender, EventArgs e) // se instala el flight plan correspondiente al auto rellenar 1
        {
            IDbox.Text = "UX123";
            compbox.Text = "Iberia";
            xfinbox.Text = "500";
            yfinbox.Text = "200";
            xinbox.Text = "50";
            yinbox.Text = "50";
            vbox.Text = "120";
        }

        private void button3_Click_1(object sender, EventArgs e) //se instala el flight plan correspondiente al auto rellenar 2
        {
            IDbox.Text = "UX222";
            compbox.Text = "Vueling";
            xfinbox.Text = "500";
            yfinbox.Text = "50";
            xinbox.Text = "50";
            yinbox.Text = "200";
            vbox.Text = "120";
        }

        private void button4_Click(object sender, EventArgs e)//se instala el flight plan correspondiente al auto rellenar 3
        {
            IDbox.Text = "UX223";
            compbox.Text = "Delta";
            xfinbox.Text = "500";
            yfinbox.Text = "125";
            xinbox.Text = "50";
            yinbox.Text = "125";
            vbox.Text = "120";
        }

        private void AñadirFP_Load(object sender, EventArgs e)
        {

        }
    }
}
