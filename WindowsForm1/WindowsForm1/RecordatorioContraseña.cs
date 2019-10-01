using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanClass;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class RecordatorioContraseña : Form
    {
        string correo;

        public RecordatorioContraseña()
        {
            //cambiamos el fondo del form
            this.BackgroundImage = Properties.Resources.background_airport;
            BackgroundImageLayout = ImageLayout.Stretch;

            InitializeComponent();
        }

        private void EnviarEmailButton_Click(object sender, EventArgs e)
        {
            //Leemos el correo que el usuario introduce en el TextBox
            correo = emailBox.Text;

            //Abrimos la base de datos
            baseops misops = new baseops();
            misops.open();

            //Recogemos el usuario y la contraseña correspondientes al correo leído
            string usuario = misops.Devuelvemeusuario(correo);
            string contraseña = misops.Devuelvemecontraseña(correo);

            //Para escribir el correo
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            //Destinatario
            mmsg.To.Add(correo);
            //Asunto
            mmsg.Subject = "Recordatorio Contraseña"; 
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            //Texto
            mmsg.Body = "Querid@ usuari@ " + usuario + " Le enviamos este correo ya que ha olvidado su contraseña. Aquí la tiene: " + contraseña + ". Muchas gracias";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("informaticaeetac2@gmail.com");
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("informaticaeetac2@gmail.com", "eetacupc");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                //Enviamos el correo
               cliente.Send(mmsg);
               //Si todo va bien informamos al usuario que ya se le ha enviado el correo
               MessageBox.Show("Correo electrónico enviado"); 
            }

            catch (Exception ex)
            {
                //Informamos si hay algún error
                MessageBox.Show("Error:" + ex.Message);
            }

            //Cerramos el form
            Close();
            }
        }
    }

