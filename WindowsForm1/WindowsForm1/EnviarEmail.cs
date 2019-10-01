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
    public partial class EnviarEmail : Form
    {
        string correo;
        string archivo;
        
        public EnviarEmail()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Leemos el correo que el usuario introduce en el TextBox
            correo = textBox1.Text;

            //si corresponde a un gmail
            string[] trozos = correo.Split('@');
            if (trozos[1] == "gmail.com")
            {
                //cogemos el informe que ya hemos creado
                archivo = "Compañías.pdf";

                //Abrimos la base de datos
                baseops misops = new baseops();
                misops.open();

                //Para escribir el correo
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                //Destinatario
                mmsg.To.Add(correo);
                //Asunto
                mmsg.Subject = "INFORME";
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                //Texto
                mmsg.Body = "Bienvenido al Simulador de Vuelo. Le adjuntamos el informe con las modificaciones que han tenido lugar durante la simulación y los datos necesarios para notificar a las compañías si así lo desea. Muchas gracias";
                mmsg.Attachments.Add(new Attachment(archivo));
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

                Close();
            }
            else
                MessageBox.Show("Sólo se pueden enviar correos electrónicos a GMAIL");
        }
    }
}
