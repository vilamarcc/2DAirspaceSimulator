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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            this.BackgroundImage = Properties.Resources.background_airport;
            BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
        }
        
        private void iniciarsesionBtn_Click(object sender, EventArgs e) //iniciar sesion
        {
            try
            {
                //Leemos los datos de los TextBox
                string n = nombreBox.Text;
                string c = contraseñaBox.Text;

                //Si alguno de los dos campos está vacío no se puede registrar
                if (n == "" || c == "") 
                    MessageBox.Show("Todos los campos son obligatorios");

                //No hay ningún campo nulo pero hay que hacer otras comprovaciones
                else
                {
                    try
                    {
                        //Abrimos la base de datos
                        baseops bbdd = new baseops();
                        bbdd.open();

                        //Busco si el usuario existe. Si no está registrado, no puede iniciar sesión
                        if (bbdd.CompruebaUsuario(n) == false)
                            MessageBox.Show("Usuario no registrado. Registrese para iniciar sesión");

                        //Sabemos que el usuario está registrado, pero hay que comprobar si la contraseña es la correcta
                        else
                        {
                            if (bbdd.CompruebaContraseña(n,c)==true) //Contraseña correcta
                            {
                                //Hacemos que no se vea este form
                                this.Hide();

                                //Abrimos el form principal
                                Demo f1 = new Demo();
                                //Le pasamos el usuario que ha iniciado sesion
                                f1.getusuario(nombreBox.Text);
                                f1.ShowDialog();
                                //Cerramos este form
                                this.Close();
                            }

                            else //Contraseña incorrecta
                                MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No existe el usuario");
                    }
                }
            }
            catch
            {
            }
            
        }

        private void registrarseBtn_Click(object sender, EventArgs e) //registrarse
        {
            //abrimos el form para registrarse
            RegistroUsuario f9 = new RegistroUsuario();
            f9.ShowDialog();
        }

        private void RecordatorioButton_Click(object sender, EventArgs e) //recordar contraseña
        {
            //Abrimos el form
            RecordatorioContraseña rc = new RecordatorioContraseña();
            rc.ShowDialog();
        }
    }
}
