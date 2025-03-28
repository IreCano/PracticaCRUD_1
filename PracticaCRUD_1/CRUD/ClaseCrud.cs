using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PracticaCRUD_1.Conexion;



    internal class ClaseCrud
    {
        // traer datos de la base de datos
        public DataTable index(string table)
        {
            ClaseConexion conexion = new ClaseConexion();

            string query = "SELECT * FROM  table";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.EjecutarConexion());

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;

        }

        //insertar en base de datos
        public void store(string nombre, string edad, string fecha_naci)
        {
            ClaseConexion mysqlConnection = new ClaseConexion();

            MySqlConnection abrirConexion = mysqlConnection.EjecutarConexion();

            string Query = "INSERT INTO `Empresa`.`Empleados`(" + "`nombre`," +"`Edad`," +"`Fecha_nacimiento`
               

            
        }

    
    }
}
