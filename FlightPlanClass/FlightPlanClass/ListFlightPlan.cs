using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FlightPlanClass
{
    public class ListFlightPlan
    {
        List<FlightPlan> ListFP = new List<FlightPlan>();

        //Constructor vacío
        public ListFlightPlan()
        {
        }

        //Constructor copia
        public ListFlightPlan(ListFlightPlan lista)
        {
            //Recorremos toda la lista copiando cada uno de los planes de vuelo
            int i = 0;
            while (i < lista.getcount())
            {
                //Utilizamos el constructor copia de la clase FlightPlan
                ListFP.Add(new FlightPlan(lista.getposicion(i))); 

                i++;
            }
        }

        //Other methods
        public int getcount() //devuelve el número de planes de vuelo que tenemos en la lista
        {
            return ListFP.Count;
        }

        public FlightPlan getposicion(int i) //devuelve el plan de vuelo en la posición dada como parámetro
        {
            return ListFP[i];
        }

        public bool añadirfp(FlightPlan fp) //añade el plan de vuelo dado como parámetro, solo si no estaba ya en la lista
        {
            int i = 0;
            bool found = false;

            //Si no hay ningún FP en la lista, se puede añadir
            if (ListFP.Count == 0)
                ListFP.Add(fp);

            //Si hay algún FP en la lista comprobamos que el que se vaya añadir no esté
            else
            {
                //Recorremos la lista buscando su ID
                while (i < ListFP.Count && found == false) 
                {
                    if (fp.GetID() == ListFP[i].GetID()) 
                        found = true;
                    else
                        i++;
                }

                //Si no lo encontramos, lo añadimos a la lista
                if (found == false)
                    ListFP.Add(fp);
            }
            return found; //found=true: ya estaba en la lista, no lo ha añadido / found=false: no estaba en la lista, lo ha añadido
        }

        public bool Hanllegadotodos() //indica si todos los vuelos han llegado a su posición final
        {
            //Si "noestan" cambia a true es porque alguno no ha llegado-->no han llegado todos
            bool noestan = false;
            int i = 0;
            while (i < ListFP.Count && noestan==false)
            {
                if (ListFP[i].HasArrived() != true)
                    noestan = true;
                i++;
            }
            return !noestan; //true han llegado, false no han llegado
        }

        public void MoverTodos(int interval) //mueve todos los vuelos de la lista hacia delante en un intervalo de tiempo dado como parámetro
        {
            int i = 0;
            while (i < ListFP.Count)
            {
                ListFP[i].Move(interval); //usamos el método move de la clase FlightPlan
                i++;
            }
        }

        public void restarttodos() //mueve todos los vuelos de la lista a su posición incial
        {
            int i = 0;
            while (i < ListFP.Count)
            {
                ListFP[i].Restart(); //usamos el método reestart de la clase FlightPlan
                i++;
            }
        }

        public Boolean BuscarConflictos(int dseg) //dice si hay conflictos o no (no los soluciona)
        {
            int i = 0;
            int j = 0;
            bool found = false;
            while (i < ListFP.Count && found == false)
            {
                FlightPlan fp1 = ListFP[i];
                while (j < ListFP.Count && i != j && found == false)
                {
                    FlightPlan fp2 = ListFP[j];
                    if (fp1.Estaranenconflicto(fp2, dseg) == true)
                        found = true;
                    j++;
                }
                i++;
            }
            return found; //found=true: hay conflictos ; found=false: no hay conflictos
        }


        public void SolucionarConflictos(int dseg, int interval) //soluciona los conflictos (se supone que antes he de comprobar si hay)
        {
            int i = 0;
            int j = 0;
            while (i < ListFP.Count)
            {
                FlightPlan fp1 = ListFP[i];
                j = 0;
                while (j < ListFP.Count && i != j)
                {
                    FlightPlan fp2 = ListFP[j];
                    while (fp1.HasArrived() == false && fp2.HasArrived() == false)
                    {
                        if (fp1.Estaenconflicto(fp2, dseg) == -1)
                            fp1.ChangeSpeedToAvoidConflict();
                        fp1.Move(interval);
                        fp2.Move(interval);
                    }
                    fp1.Restart();
                    fp2.Restart();
                    j++;
                }
                i++;
            }
        }

        public void GuardarVuelos(string fichero) //escribe fichero con los datos actuales de los vuelos
        {
            StreamWriter W = new StreamWriter(fichero); //escribir fichero
            int i = 0;
            while (i < ListFP.Count)
            {
                FlightPlan f = ListFP[i];
                W.WriteLine(f.GetID() + " " + f.GetCompañia() + " " + Convert.ToString(f.GetVelocidad()) + " " + Convert.ToString(f.GetIX()) + " " + Convert.ToString(f.GetIY()) + " " + Convert.ToString(f.GetAX()) + " " + Convert.ToString(f.GetAY()) + " " + Convert.ToString(f.GetFX()) + " " + Convert.ToString(f.GetFY()));
                i++;
            }
            W.Close(); //cerrar fichero
        }

        public void CargarFichero(string fichero) //lee un fichero con datos de vuelos
        {
            StreamReader R = new StreamReader(fichero); //leer fichero
            string linea = R.ReadLine();//leer primera línea
            while (linea != null)
            {
                string[] trozos = linea.Split(' '); //partimos la linea por los espacios

                //leemos los datos
                string id = trozos[0];
                string compañia = trozos[1];
                double velocidad = Convert.ToDouble(trozos[2]);
                double ix = Convert.ToDouble(trozos[3]);
                double iy = Convert.ToDouble(trozos[4]);
                double fx = Convert.ToDouble(trozos[7]);
                double fy = Convert.ToDouble(trozos[8]);

                //creamos el FP
                FlightPlan fp = new FlightPlan(id, compañia, velocidad, ix, iy, fx, fy);

                //asignamos la posicion actual (en el constructor a la posición actual se le asigna la inicial)
                fp.SetAX(Convert.ToDouble(trozos[5]));
                fp.SetAY(Convert.ToDouble(trozos[6]));

                //añadimos el fp a la lista
                ListFP.Add(fp);

                linea = R.ReadLine();
            }
            R.Close(); //cerrar fichero
        }

        public List<double> DadmeDistancias(int pos) //Nos da una lista con distancias entre el vuelo en la posición dada como parámetro y todos los demás vuelos
        {
            //Cogemos el plan de vuelo en la posición dada como parámetro
            FlightPlan fp = ListFP[pos];

            //Creamos la lista que nos va a devolver
            List<double> dist = new List<double>();

            //Recorremos la lista
            int i = 0;
            while (i < ListFP.Count)
            {
                //Mientras no sea el vuelo respecto al que estamos calculando las distancias, calculamos y metemos en la lista
                if (i != pos)
                    dist.Add(fp.Distance(ListFP[i]));

                i++;
            }

            //Devolvemos la lista
            return dist;
        }
    }
}
