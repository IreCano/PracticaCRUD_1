using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PracticaCRUD_1.Conexion
{
    internal class ClaseConexion
    {
        //Aqui debo traer los datos de la BD
        public DataTable index(string table)
        {
            rutaconexion conexion = new rutaconexion();

            string query = "SELECT * FROM " + table + "";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.ToString());

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;

        }

        private string rutaconexion = "Server=mysql.censa.duckdns.org;User=root;Password=rootpassword;Database=Empresa";

        public MySqlConnection EjecutarConexion()
        {

            MySqlConnection mySqlConnection = new MySqlConnection(this.rutaconexion);
            mySqlConnection.Open();
            return mySqlConnection;
        }

    }


}
