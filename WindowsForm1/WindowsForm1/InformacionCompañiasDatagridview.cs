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
using System.Data.SqlClient;
using System.Configuration;
using System.Resources;
using System.Reflection;
using WindowsFormsApplication1.Properties;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class InformacionCompañiasDatagridview : Form
    {
        int compfila;
        string direclogo;
        string namecomp;
        string usuario;
        int intfondo;

        public InformacionCompañiasDatagridview()
        {
            InitializeComponent();
            this.button3.Hide();
        }

        public void cambiarfondo(int fondo)
        {
            //Depende del número, se pondrá un fondo u otro

            if (fondo == 1)
            {
                this.BackgroundImage = Properties.Resources.background_airport;
                BackgroundImageLayout = ImageLayout.Stretch;
                intfondo = 1;
            }

            if (fondo == 2)
            {
                this.BackgroundImage = Properties.Resources.nubes;
                BackgroundImageLayout = ImageLayout.Stretch;
                intfondo = 2;
            }

            if (fondo == 3)
            {
                this.BackgroundImage = Properties.Resources.paisaje;
                BackgroundImageLayout = ImageLayout.Stretch;
                intfondo = 3;
            }

            if (fondo == 4)
            {
                this.BackgroundImage = Properties.Resources.puesta_de_sol;
                BackgroundImageLayout = ImageLayout.Stretch;
                intfondo = 4;
            }

            if (fondo == 5)
            {
                this.BackgroundImage = Properties.Resources.noche;
                BackgroundImageLayout = ImageLayout.Stretch;
                intfondo = 5;
            }

            if (fondo == 6)
            {
                this.BackgroundImage = Properties.Resources.aurora;
                BackgroundImageLayout = ImageLayout.Stretch;
                intfondo = 6;
            }
        }

        private void button1_Click(object sender, EventArgs e) //abre un nuevo form para poder registrar una nueva compañia
        {
            if (usuario == "administrador")
            {
                RegistroCompañia f11 = new RegistroCompañia();
                f11.cambiarfondo(intfondo);
                f11.ShowDialog();

                baseops comp = new baseops();
                comp.open();
                try
                {
                    //Creamos la tabla del gridview
                    DataTable res2 = comp.GetAllComp();
                    dataGridView1.RowCount = res2.Rows.Count;
                    dataGridView1.ColumnCount = 1;
                    dataGridView1.ColumnHeadersVisible = false;
                    dataGridView1.RowHeadersVisible = false;

                    //recorremos la tabla
                    int i = 0;
                    while (i < res2.Rows.Count)
                    {
                        //escribe el nombre de todas las compañias en el data grid view
                        dataGridView1[0, i].Value = res2.Rows[i]["Name"];

                        i++;
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception exc) //si hay un error informamos al usuario
                {
                    MessageBox.Show("Error: " + exc);
                }

                comp.close();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No eres administrador");
            }
        }

        private void Form12_Load(object sender, EventArgs e) //Mostramos un DataGridView con las compañias de los vuelos que han sido registrados
        {
            baseops comp = new baseops();

            try
            {
                //abre la base de datos
                comp.open();

                //guarda todos los componentes que es encuentran en la base de datos usuarios, tabla compañias.
                DataTable res2 = comp.GetAllComp();
                dataGridView1.RowCount = res2.Rows.Count;
                dataGridView1.ColumnCount = 1;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;

                //recorremos la tabla
                int i = 0;
                while (i < res2.Rows.Count)
                {
                    //escribe el nombre de todas las compañias en el data grid view
                    dataGridView1[0, i].Value = res2.Rows[i]["Name"];

                    i++;
                }

                dataGridView1.Refresh();
            }
            catch (Exception exc) //si hay un error informamos al usuario
            {
                MessageBox.Show("Error: " + exc);
            }
            comp.close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //al apretar sobre el nombre de las compañias aparece el email el telefono y su respectivo logo
        {
            //Cogemos la fila sobre la que se ha clicado
            this.compfila = e.RowIndex;

            //abre dase de datos
            baseops comp = new baseops();
            comp.open();

            //se adquiere el nombre de la compañia sobre la cual hemos clicado
            string name = Convert.ToString(dataGridView1[0, compfila].Value);
            namecomp = name;

            //buscamos los datos de la compañia de la que hemos clicado y escribimos su informacion en los textbox y añadimos su logo (si hay)
            DataTable res = comp.GetCompañia(name);

            emailbox.Text = Convert.ToString(res.Rows[0]["Email"]);
            telefbox.Text = Convert.ToString(res.Rows[0]["Telefono"]);

            direclogo = Convert.ToString(res.Rows[0]["Logo"]);

            this.button3.Show();

            if (direclogo != null) // si al registrarse se había añadido un logo se pone
            {
                try
                {
                    string path = Path.Combine(Application.StartupPath, @"..\..\Resources", direclogo);
                    Bitmap logo = (Bitmap)Image.FromFile(path);
                    panelogo.BackgroundImage = logo;
                }
                catch
                {
                    panelogo.BackgroundImage = Properties.Resources.missing;
                }
            }

            if (direclogo == "missing") //si al registrarse no se había añadido un logo, no aparece ninguna imagen
            {
                panelogo.BackgroundImage = Properties.Resources.missing;
            }

            dataGridView1.Refresh();

            //Cerramos la bbdd
            comp.close();
        }
        
        private void button3_Click(object sender, EventArgs e) //elimina alguna compañia que habia sido registrada
        {
            if (usuario == "administrador")
            {
                //abre base de datos
                baseops misops = new baseops();
                misops.open();

                //elimina la compañia
                int result = misops.EliminarComp(namecomp);

                //Si se ha modificado una fila de la bbdd es porque se ha eliminado bien
                if (result == 1)
                    MessageBox.Show("La compañia: " + namecomp + ", ha sido eliminada de la base de datos.");

                //Si no se ha modificado una fila, algo no ha funcionado
                else
                    MessageBox.Show("No ha podido realizarse la operación");
                try
                {
                    DataTable res2 = misops.GetAllComp();
                    dataGridView1.RowCount = res2.Rows.Count;
                    dataGridView1.ColumnCount = 1;
                    dataGridView1.ColumnHeadersVisible = false;
                    dataGridView1.RowHeadersVisible = false;

                    //recorremos la tabla
                    int i = 0;
                    while (i < res2.Rows.Count)
                    {
                        //escribe el nombre de todas las compañias en el data grid view
                        dataGridView1[0, i].Value = res2.Rows[i]["Name"];

                        i++;
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception exc) //si hay un error informamos al usuario
                {
                    MessageBox.Show("Error: " + exc);
                }
                misops.close();
            }
            else
                MessageBox.Show("No eres administrador");
        }
        
        public void Setusuario(string usuario) //para sacar el usuario por si es admin
        {
            this.usuario = usuario;
        }
    }
}
