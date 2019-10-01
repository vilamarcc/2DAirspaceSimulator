using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightPlanClass
{
    public class FlightPlan
    {
        string ID; //identificador de vuelo
        string compañia;
        double velocidad; //en nudos
        double IX; //coordenada x inicial
        double IY; //coordenada y inicial
        double FX; //coordenada x final
        double FY; //coordenada y final
        double AX; //coordenada x actual
        double AY; //coordenada y actual
        double incrementov;

        //setters & getters
        public void SetID(string identf)
        {
            this.ID = identf;
        }

        public string GetID()
        {
            return this.ID;
        }

        public void SetCompañia(string comp)
        {
            this.compañia = comp;
        }

        public string GetCompañia()
        {
            return this.compañia;
        }

        public void SetVelocidad(double vel)
        {
            this.velocidad = vel;
        }

        public double GetVelocidad()
        {
            return this.velocidad;
        }

        public void SetIX(double xini)
        {
            this.IX = xini;
        }

        public double GetIX()
        {
            return this.IX;
        }

        public void SetIY(double yini)
        {
            this.IY = yini;
        }

        public double GetIY()
        {
            return this.IY;
        }

        public void SetFX(double xfin)
        {
            this.FX = xfin;
        }

        public double GetFX()
        {
            return this.FX;
        }

        public void SetFY(double yfin)
        {
            this.FY = yfin;
        }

        public double GetFY()
        {
            return this.FY;
        }

        public void SetAX(double xact)
        {
            this.AX = xact;
        }

        public double GetAX()
        {
            return this.AX;
        }

        public void SetAY(double yact)
        {
            this.AY = yact;
        }

        public double GetAY()
        {
            return this.AY;
        }

        public void SetIncrementoV(double incrv)
        {
            this.incrementov = incrv;
        }

        public double GetIncrementoV()
        {
            return this.incrementov;
        }

        //Constructor lleno
        public FlightPlan(string identf, string comp, double vel, double xini, double yini, double xfin, double yfin)
        {
            this.ID = identf;
            this.compañia = comp;
            this.velocidad = vel;
            this.IX = xini;
            this.FX = xfin;
            this.AX = xini;
            this.IY = yini;
            this.FY = yfin;
            this.AY = yini;
            this.incrementov = 0;
        }

        //Constructor vacío
        public FlightPlan()
        {
        }

        //Constructor copia
        public FlightPlan(FlightPlan fp)
        {
            this.ID = fp.GetID();
            this.compañia = fp.GetCompañia();
            this.velocidad = fp.GetVelocidad();
            this.IX = fp.GetIX();
            this.FX = fp.GetFX();
            this.AX = fp.GetAX();
            this.IY = fp.GetIY();
            this.FY = fp.GetFY();
            this.AY = fp.GetAY();
            this.incrementov = fp.GetIncrementoV();
        }

        //Other methods
        public Boolean HasArrived() //true=el avión ha llegado; false=no ha llegado
        {
            //si la posición actual es la final, ha llegado
            if ((AX == FX) && (AY == FY))
                return true;

            //sino, no ha llegado
            else
                return false;
        }

        public double Distance(FlightPlan plan) //calcula la distancia entre mi avión y la del avión del flightplan dado como parámetro
        {
            return Math.Sqrt((this.AX - plan.AX) * (this.AX - plan.AX) + (this.AY - plan.AY) * (this.AY - plan.AY));
        }

        public void Move(double time) //mueve el vuelo hacia delante a la posición correspondiente a viajar durante un tiempo time dado como parámetro
        {
            double D = (time * (this.velocidad / 60));//D: distancia total que va a recorrer
            //trigonometría
            double H = Math.Sqrt((this.FX - this.AX) * (this.FX - this.AX) + (this.FY - this.AY) * (this.FY - this.AY)); //H: distancia que hay desde donde está hasta su posición final
            double C = (this.FX - this.AX) / H; //C: coseno
            double S = (this.FY - this.AY) / H; //S: seno
            if (H < D) //exigimos que no pase de la posición final
            {
                this.AX = this.FX;
                this.AY = this.FY;
            }
            else
            {
                this.AX = this.AX + D * C;
                this.AY = this.AY + D * S;
            }
        }

        public void Restart() //mueve el avión a su posición inicial
        {
            this.AX = this.IX;
            this.AY = this.IY;
        }

        public int Estaenconflicto(FlightPlan plan, double ds) //dice si hay o no conflicto entre dos vuelos
        {
            //calculamos la distancia entre los dos vuelos
            double distace = this.Distance(plan);

            //si la distancia entre los dos vuelos es menor a la de seguridad, hay conflicto
            if (distace <= ds)
                return -1; //hay conflicto

            //si la distancia entre los dos vuelos es mayor a la de seguridad, no hay conflicto
            else
                return 0; //no hay conflicto
        }

        public void ChangeSpeedToAvoidConflict() //Cambia la velocidad para que no haya conflicto
        {
            this.SetVelocidad(this.GetVelocidad() + 0.5);
        }
 
            public Boolean Estaranenconflicto(FlightPlan plan, double ds) //dice si habrá, en un futuro, conflicto entre el fp y el fp dado omo parametro
        {
            //Parámetros fp clase
            double Hthis = Math.Sqrt((this.FX - this.AX) * (this.FX - this.AX) + (this.FY - this.AY) * (this.FY - this.AY)); //H: distancia que hay desde donde está hasta su posición final
            double Cthis = (this.FX - this.AX) / Hthis; //C: coseno
            double Sthis = (this.FY - this.AY) / Hthis; //S: seno

            //Parámetros fp plan
            double Hplan = Math.Sqrt((plan.FX - plan.AX) * (plan.FX - plan.AX) + (plan.FY - plan.AY) * (plan.FY - plan.AY)); //H: distancia que hay desde donde está hasta su posición final
            double Cplan = (plan.FX - plan.AX) / Hplan; //C: coseno
            double Splan = (plan.FY - plan.AY) / Hplan; //S: seno

            double OX = this.GetIX() - plan.GetIX();
            double OY = this.GetIY() - plan.GetIY();

            double CV = (this.GetVelocidad() * Cthis - plan.GetVelocidad() * Cplan) / 3600;
            double SV = (this.GetVelocidad() * Sthis - plan.GetVelocidad() * Splan) / 3600;

            //Definimos el parámetro distancia
            double distancia;

            //Caso particular: los dos aviones vuelan en la misma dirección, en el mismo sentido y a la misma velocidad --> la distancia será siempre la misma
            if (SV == 0 && CV == 0)
                distancia = this.Distance(plan); //me da igual en la posición que estén

            //Todos los demás casos:
            //Las fórmulas que usamos las hemos obtenido manualmente optimizando la distancia y con las ecuaciones del movimiento
            else
            {
                //Momento en el que la distancia será mínima
                double t = -(OY * SV + OX * CV) / (CV * CV + SV * SV);
                //Distancia mínima
                distancia = Math.Sqrt((OX + t * CV) * (OX + t * CV) + (OY + t * SV) * (OY + t * SV));
            }

            if (distancia < ds)
                return true;
            else
                return false;
        
        }
    }
}