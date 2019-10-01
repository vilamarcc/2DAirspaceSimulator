using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FlightPlanClass;
using System.Windows.Forms;
using System.Resources;
using System.Configuration;
using System.Reflection;
using WindowsFormsApplication1.Properties;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class InformacionVueloClickavion : Form
    {
        FlightPlan myfp;
        ResourceManager rm;

        public InformacionVueloClickavion()
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

        public void setFlight(FlightPlan fp) //Cogemos el FP dado como parámetro
        {
            this.myfp = fp;
        }

        private void button1_Click(object sender, EventArgs e) //Para cerrar el form
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e) //insertamos en cada TextBox su valor
        {
            //Ponemos en cada textbox el valor correspondiente
            idbox.Text = Convert.ToString(myfp.GetID());
            compbox.Text = Convert.ToString(myfp.GetCompañia());
            velbox.Text = Convert.ToString(myfp.GetVelocidad());
            posinbox.Text = "(" + Convert.ToString(myfp.GetIX()) + "," + Convert.ToString(myfp.GetIY()) + ")";
            decimal posactualx = Decimal.Round(Convert.ToDecimal(myfp.GetAX()), 2);
            decimal posactualy = Decimal.Round(Convert.ToDecimal(myfp.GetAY()), 2);
            posactbox.Text = "(" + Convert.ToString(posactualx) + "," + Convert.ToString(posactualy) + ")";
            posfinbox.Text = "(" + Convert.ToString(myfp.GetFX()) + "," + Convert.ToString(myfp.GetFY()) + ")";

            //Abrimos la bbdd para coger los datos de las compañías
            baseops misops = new baseops();
            misops.open();

            //Cogemos el nombre de la compañía (que es un atributo de la clase flightplan
            string name = Convert.ToString(myfp.GetCompañia());

            //Comprobamos que esté en la bbdd
            bool check = misops.compruebacomp(name);

            //Si está:
            if (check == true)
            {
                //Cogemos los datos de la compañía con nombre name
                DataTable res = misops.GetCompañia(name);

                //Los escribimos en los textbox
                emailbox.Text = Convert.ToString(res.Rows[0]["Email"]);
                telefbox.Text = Convert.ToString(res.Rows[0]["Telefono"]);

                //Para añadir el logo:
                string direclogo = Convert.ToString(res.Rows[0]["Logo"]);

                if (direclogo != null) //Si hay un logo disponible lo usamos
                {
                    try
                    {
                        string path = Path.Combine(Application.StartupPath, @"..\..\Resources", direclogo);
                        Bitmap logo = (Bitmap)Image.FromFile(path);
                        panelogo.BackgroundImage = logo;
                        panelogo.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch
                    {
                        panelogo.BackgroundImage = Properties.Resources.missing;
                        panelogo.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                if (direclogo == "missing" || direclogo == null)
                    panelogo.BackgroundImage = Properties.Resources.missing;
            }

            //Si no está:
            else
            {
                panelogo.BackgroundImage = Properties.Resources.missing;
                panelogo.BackgroundImageLayout = ImageLayout.Stretch;

                emailbox.Text = "(No disponible)";
                telefbox.Text = "(No disponible)";
            }

            //Cerramos la bbdd
            misops.close();
        }
    }
}
