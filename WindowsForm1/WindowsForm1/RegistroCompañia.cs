using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using FlightPlanClass;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApplication1
{
    public partial class RegistroCompañia : Form
    {
        string nombrecomp;
        string email;
        int num;
        string filepath; //nombre del logo con la extension
        string fName; //nombre que va dentro de la base de datos sin la extension
        string archivo; //nombre completo del archivp (con extension)
        string resourcesfolder; //directorio de la carpeta de resources
        OpenFileDialog ofd = new OpenFileDialog();
        string directoryname; //directorio del archivo original que buscamos

        public RegistroCompañia()
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
        
        private void button2_Click(object sender, EventArgs e) //Cerrar
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e) //Aceptar
        {
            nombrecomp = nombox.Text;
            email = emailbox.Text;
            if (telefbox.Text != null) //Comprobamos si han puesto un numero de telefono
            {
                try
                {
                    num = Convert.ToInt32(telefbox.Text); //Comprobamos si es valido
                }
                catch
                {
                    MessageBox.Show("Inserta un número de teléfono válido.");
                }
            }

            if (nombrecomp == "" || email == "") //forzamos a que se ponga un nombre y un mail
                MessageBox.Show("Rellena los campos obligatorios");
            
            else
            {
                try
                {
                    baseops ops = new baseops();
                    ops.open();
                    bool check = ops.compruebacomp(nombrecomp); // comprobamos si la compañia ya esta registrada

                    if (check == true)
                        MessageBox.Show("La compañía ya está registrada");
                    
                    if (check == false)
                    {
                        if (logobox == null) //si no han especificado un logo entonces añadimos la compañia sin logo
                        {
                            ops.AddComp(nombrecomp, email, num);
                            MessageBox.Show("Compañia registrada con éxito");
                            Close();
                        }

                        else //Si hay un logo disponible lo añadimos con la funcion de añadir con logo
                        {
                            ops.AñadirCompconlogo(nombrecomp, email, num, fName);

                            try
                            {
                                resourcesfolder = Path.Combine(Application.StartupPath, @"..\..\Resources");
                                File.Copy(Path.Combine(directoryname, archivo), Path.Combine(resourcesfolder, archivo), true); //esta funcion nos coge el objeto 'archivo' del 'directoryname' (donde esta hubicado el archivo original que queremos mover y lo mueve a la carpeta de resources, el true es para sobreescribir el archivo si ya hay uno con el mismo nombre en la carpeta
                            }

                            catch 
                            {
                            }

                            MessageBox.Show("Compañia registrada con éxito");
                            Close();
                        }
                    }
                    ops.close();
                }
                catch 
                {
                }
            }
        }


        private void button4_Click(object sender, EventArgs e) //Cargar logo
        {
            //solo se pueden cargar archivos de tipo jpeg o png
            ofd.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                logobox.Text = ofd.FileName; //sacamos el path entero
                filepath = logobox.Text;
                string[] separador = ofd.SafeFileName.Split('.'); //separamos el nobre de la extensión
                fName = ofd.SafeFileName; //cogemos el nombre que pondremos en la base de datos de el logo
                archivo = ofd.SafeFileName; //nombre del archivo
                directoryname = Path.GetDirectoryName(filepath); //sacamos el path entero para usarlo luego para mover el archivo a la carpeta de resources
            }
        }

    }
}
