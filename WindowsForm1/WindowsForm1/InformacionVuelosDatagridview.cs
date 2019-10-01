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


namespace WindowsFormsApplication1
{
    public partial class InformacionVuelosDatagridview : Form
    {
        ListFlightPlan mylist;
        int fila;

        public InformacionVuelosDatagridview()
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

        public void setlist(ListFlightPlan listfp) //asignamos una lista
        {
            this.mylist = listfp;
        }

        public int getfila() //devolvemos el parámetro fila
        {
            return this.fila;
        }

        public ListFlightPlan getlist() //devolvemos la lista
        {
            return this.mylist;
        }

        private void button1_Click(object sender, EventArgs e) //boton cerrar
        {
            //los vuelos vuelven a la posición inicial y cerramos
            mylist.restarttodos();
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //creamos el data grid view
            panelgrid.ColumnCount = mylist.getcount() + 1;
            panelgrid.RowCount = 7;
            panelgrid.ColumnHeadersVisible = false;
            panelgrid.RowHeadersVisible = false;
            panelgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //ponemos las cabeceras
            panelgrid[0, 0].Value = "ID";
            panelgrid[0, 1].Value = "Compañia";
            panelgrid[0, 2].Value = "Velocidad";
            panelgrid[0, 3].Value = "Inicio";
            panelgrid[0, 4].Value = "Fin";
            panelgrid[0, 5].Value = "Email";
            panelgrid[0, 6].Value = "Telefono";

            //abrimos la bbdd para coger los datos
            baseops misops = new baseops();
            misops.open();

            //Check nos dice si la compañía está en la bbdd
            bool check = false;

            //Recorremos la lista
            int i = 0;
            while (i < mylist.getcount())
            {
                //cogemos el fp
                FlightPlan fp = mylist.getposicion(i);

                //ponemos los datos del fp en el datagridview
                panelgrid[i + 1, 0].Value = fp.GetID();
                panelgrid[i + 1, 2].Value = Convert.ToString(fp.GetVelocidad());
                panelgrid[i + 1, 3].Value = Convert.ToString("(" + fp.GetIX() + "," + fp.GetIY() + ")");
                panelgrid[i + 1, 4].Value = Convert.ToString("(" + fp.GetFX() + "," + fp.GetFY() + ")");

                //comprobamos si la compañía de ese vuelo está o no en la bbdd
                check = misops.compruebacomp(Convert.ToString(fp.GetCompañia()));

                //Si está:
                if (check == true)
                {
                    //Cogemos los datos de esa compañía
                    DataTable res = misops.GetCompañia(Convert.ToString(fp.GetCompañia()));

                    //Los escribimos en el datagridview
                    panelgrid[i + 1, 5].Value = res.Rows[0]["Email"];
                    panelgrid[i + 1, 6].Value = Convert.ToString(res.Rows[0]["Telefono"]);
                    panelgrid[i + 1, 1].Value = res.Rows[0]["Name"];

                }
                    
                //si la compañía no está en la bbdd:
                if (check == false)
                {
                    //En el datagridview marcamos los datos correspondientes como no disponibles
                    panelgrid[i + 1, 5].Value = "(No Disponible)";
                    panelgrid[i + 1, 6].Value = "(No Disponible)";
                    panelgrid[i + 1, 1].Value = Convert.ToString(fp.GetCompañia());
                }
                    
                //Cerramos la bbdd
                misops.close();
                    
                i++;
            }
        }

        private void panelgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cogemos el índex de la columna clicada
            this.fila = e.ColumnIndex;

            //Si es la primera columna no podemos hacer nada porque son las cabeceras
            if (fila == 0)
                MessageBox.Show("Clica en un plan de vuelo");

            //Si es cualquier otra fila, nos saldrá un mensaje con las distancias a cada uno de los demás planes de vuelos
            if (fila != 0)
            {
                //Si solo hay un vuelo en la lista, no hay distancias
                if (mylist.getcount() == 1)
                    MessageBox.Show("No hay más vuelos para calcular distancia");

                //Si hay dos vuelos, solo tendremos una distancia
                if (mylist.getcount() == 2)
                    MessageBox.Show("Distancia entre los vuelos: " + mylist.getposicion(0).Distance(mylist.getposicion(1)));

                //Si hay más de dos vuelos:
                if (mylist.getcount() > 2)
                {
                    //Mensaje que mostraremos (le vamos añadiendo líneas)
                    string mensaje = "Distancias:" + "\n";

                    //Definimos dos parámetros que usaremos
                    string id;
                    double dist;

                    //Cambiamos la variable
                    fila = fila - 1;

                    //Recorremos la lista hasta llegar a la posición del vuelo clicado
                    int i = 0;
                    if (i >= 0 && i != fila)
                    {
                        while (i < fila)
                        {
                            //Cogemos la ID y la distancia con el siguiente vuelo
                            id = mylist.getposicion(i).GetID();
                            dist = mylist.DadmeDistancias(fila)[i];

                            //Añadimos distancia al mensaje
                            mensaje = mensaje + "Con vuelo " + id + ": " + Convert.ToString(dist) + "\n";

                            i++;
                        }
                    }

                    //Recorremos lo que falta de la lista
                    if (i >= fila)
                    {
                        while (i < mylist.DadmeDistancias(fila).Count)
                        {
                            //Cogemos la ID y la distancia con el siguiente vuelo
                            id = mylist.getposicion(i + 1).GetID();
                            dist = mylist.DadmeDistancias(fila)[i];

                            //Añadimos distancia al mensaje
                            mensaje = mensaje + "Con vuelo " + id + ": " + Convert.ToString(dist) + "\n";

                            i++;
                        }
                    }
                    MessageBox.Show(mensaje);
                }
            
            
            //if (fila == 0)
            //    MessageBox.Show("Clica en un plan de vuelo");

            ////nos da la distancia que hay entre el vuelo clicado y el anterior, si clicamos al de la última columna nos indica la distancia de él con el de la primera
            //if (fila != 0)
            //{
            //    //Creamos el parámetro
            //    double distancia;

            //    //cogemos el flightplan
            //    FlightPlan fp = mylist.getposicion(fila - 1);

            //    //Caso particular: si se clica encima del último vuelo, da la distancia entre ese y el primero
            //    if (fila == mylist.getcount())
            //        distancia = fp.Distance(mylist.getposicion(0));

            //    //Todos los demás casos:
            //    else
            //        distancia = fp.Distance(mylist.getposicion(fila));

            //    //mostramos la distancia en un messagebox
            //    MessageBox.Show("Distancia entre el vuelo en el que has clicado y el siguiente de la lista: " + distancia);
            }
        }

        private void panelgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)//cambiar velocidad
        {
            //si se clica encima de un valor correspondiente a la velocidad se puede modificar
            if (panelgrid[0, e.RowIndex].Value == "Velocidad" && e.ColumnIndex != 0)
            {
                try
                {
                    //Cogemos el fp corespondiente
                    FlightPlan fp = mylist.getposicion(e.ColumnIndex - 1);

                    //Asignamos al flightplan el incremento de velocidad
                    fp.SetIncrementoV(Convert.ToDouble(panelgrid[e.ColumnIndex, e.RowIndex].Value) - fp.GetVelocidad());
                    
                    //le asignamos la nueva velocidad
                    fp.SetVelocidad(Convert.ToDouble(panelgrid[e.ColumnIndex, e.RowIndex].Value));
                }
                catch //Si hay un error informamos al usuario
                {
                    MessageBox.Show("Error de formato");
                }
            }
        }
    }
}
