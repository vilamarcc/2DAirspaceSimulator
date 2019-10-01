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
    public partial class CargarFicheroFP : Form
    {
        string archivo;
        OpenFileDialog ofd = new OpenFileDialog();

        public CargarFicheroFP()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.nubes;
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

        private void button1_Click(object sender, EventArgs e) //boton de cargar fichero desde el sistema
        {
            //solo se pueden cargar archivos de tipo txt
            ofd.Filter = "TXT |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                archivo = textBox1.Text;
                textBox2.Text = ofd.SafeFileName;
            }
        }

        public string Getarchivo() //retorna el nombre del archivo que coje
        {
            return archivo;
        }

        private void button2_Click(object sender, EventArgs e) //boton de aceptar el fichero para usarlo
        {
            //si no se ha escogido ningun archivo
            if (textBox1.Text == "" | textBox2.Text == "")
                MessageBox.Show("Revisa los datos");

            //si todo ha ido bien cerramos
            else
                Close();
        }
    }
}
