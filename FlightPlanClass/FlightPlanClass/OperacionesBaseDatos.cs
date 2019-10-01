using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace FlightPlanClass
{
    public class baseops //Sirven para las dos tablas
    {
        OleDbConnection cnx;

        public void open() //abre la base de datos
        {
            string nombreCompleto = "..\\..\\usuarios.sdf";
            string cnxstr = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=" + nombreCompleto + ";Persist Security Info=False;";
            cnx = new OleDbConnection(cnxstr); //base de datos
            try
            {
                cnx.Open();
            }
            catch
            {
            }
        }

        public void close() //cierra la bbdd
        {
            cnx.Close();
        }

        //Métodos relacionados con la tabla de compañías

        public int AddComp(string name, string email, int num) //añade una compañía a la tabla de compañias (sin logo)
        {
            string query = "INSERT INTO Compañias (Name, Email, Telefono) VALUES ('" + name + "', '" + email + "', " + num + ")";
            OleDbCommand command = new OleDbCommand(query, cnx);
            int resultado = command.ExecuteNonQuery();
            return resultado;
        }
          
        public DataTable GetAllComp() //crea una tabla con todos los datos de compañias
        {
            string query = "SELECT * FROM Compañias";
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            DataTable res = new DataTable();
            adp.Fill(res);
            return res;
        }

        public bool compruebacomp(string name) //comprueba si una compañia ya esta en la bbdd
        {
            bool comprueba = false; //falso es que no existe esa compañia, true es que si que esta en nuestra base de datos
            string query = "SELECT Name FROM Compañias WHERE (Name = '" + name + "')";
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            DataTable res = new DataTable();
            adp.Fill(res);

            if (res.Rows.Count != 0)
                comprueba = true;

            return comprueba;
        }
        public DataTable GetCompañia(string name) //devuelve todos los datos de una compañia en una tabla
        {
            string query = "SELECT * FROM Compañias WHERE(Name = '" + name + "')";
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            DataTable res = new DataTable();
            adp.Fill(res);
            return res;
        }

        public int EliminarComp(string name) //elimina una compañia con el nombre dado
        {
            string query = "DELETE FROM Compañias WHERE (Name = '" + name + "')";
            OleDbCommand odp = new OleDbCommand(query, cnx);
            int result = odp.ExecuteNonQuery();
            return result;
        }

        public int AñadirCompconlogo(string name, string email, int num, string logo) //Añade una compañia con logo
        {
            string query = "INSERT INTO Compañias (Name, Email, Telefono, Logo) VALUES ('" + name + "', '" + email + "', " + num + ",'" + logo + "')";
            OleDbCommand command = new OleDbCommand(query, cnx);
            int resultado = command.ExecuteNonQuery();
            return resultado;
        }


        //Métodos relacionados con la tabla de usuarios

        public int AddUsuario(string nombreusuario, string pass, string correoelec) //añade un usuario a la tabla de usuarios
        {
            string query = "INSERT INTO Usuarios VALUES ('" + nombreusuario + "','" + pass + "','" + correoelec + "')";
            OleDbCommand command = new OleDbCommand(query, cnx);
            int resultado = command.ExecuteNonQuery();

            return resultado;
        }

        public bool CompruebaUsuario(string name) //comprueba si un usuario ya esta en la bbdd
        {
            bool comprueba = false; //falso es que no hay ningun usuario con ese nombre, true esque hay ya un usuario registrado
            string query = "SELECT Nombre FROM usuarios WHERE (Nombre = '" + name + "')";
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            DataTable res = new DataTable();
            adp.Fill(res);

            if (res.Rows.Count != 0)
                comprueba = true;

            return comprueba;
        }

        public bool CompruebaContraseña(string name, string contraseña) //comprueba si la contraseña del usuario le corresponde 
        {
            bool comprueba = false;
            string query = "SELECT Contraseña FROM usuarios WHERE (Nombre = '" + name + "') AND (Contraseña='" + contraseña + "')";
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            DataTable res = new DataTable();
            adp.Fill(res);

            if (res.Rows.Count != 0)
                comprueba = true;

            return comprueba; //true: el usuario "name" tiene contraseña "contraseña" 
        }

        public string Devuelvemeusuario(string email) //devuelve el nombre del usuario con el email dado como parámetro
        {
            string query = "SELECT Nombre FROM usuarios WHERE Email ='" + email + "'";
            DataTable res = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            adp.Fill(res);
            string usuario = Convert.ToString(res.Rows[0]["Nombre"]);
            return usuario;
        }
        
        public string Devuelvemecontraseña(string email) //devuelve la contraseña del usuario con el email dado como parámetro
        {
            string query = "SELECT Contraseña FROM usuarios WHERE Email ='" + email + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter(query, cnx);
            DataTable res = new DataTable();
            adp.Fill(res);
            string usuario = Convert.ToString(res.Rows[0]["Contraseña"]);
            return usuario;
        }

        
    }
}
