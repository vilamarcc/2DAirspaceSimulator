using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanClass;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class RegistroUsuario : Form
    {
        string nombreusuario;
        string contraseña1;
        string contraseña2;
        string correo;
        
        public RegistroUsuario()
        {
            //cambiamos el fondo del form
            this.BackgroundImage = Properties.Resources.background_airport;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nombreusuario = nombreBox.Text;
                contraseña1 = contraseña1Box.Text;
                contraseña2 = contraseña2Box.Text;
                correo = EmailBox.Text;
                //comprobamos que se hayan llenado todos los campos y si es así que las contraseñas coincidan
                if (nombreusuario == "" || contraseña1 == "" || contraseña2 == "" || correo == "")
                    MessageBox.Show("Todos los campos son obligatorios");
                else
                {
                    if (contraseña1 != contraseña2)
                        MessageBox.Show("Las contraseñas no coinciden");
                    string[] trozos = correo.Split('@');
                    if (trozos[1] != "gmail.com")
                    {
                        MessageBox.Show("Sólo valido el registro con correo electrónico GMAIL");
                    }
                    else
                    {
                        try
                        {
                            baseops misops = new baseops();
                            misops.open();
                            bool comprobar = misops.CompruebaUsuario(nombreusuario);
                            if (comprobar == true)
                                MessageBox.Show("Nombre de usuario ya existente. Elige otro");
                            else
                            {
                                if (misops.AddUsuario(nombreusuario,contraseña1,correo) == 1)
                                {
                                    MessageBox.Show("Registrado");
                                    Close();
                                }
                                else // mostramos si no ha sido posible hacer el registro
                                    MessageBox.Show("No ha sido posible el registro");
                                misops.close();
                            }
                        }
                        catch //el programa no ha encontrado la base de datos
                        {
                            {
                                MessageBox.Show("Base de Datos no encontrada");
                                Close();
                            }
                        }
                    }
                }
            }

            catch (Exception u)
            {
                MessageBox.Show("Error: " + u.Message);
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
