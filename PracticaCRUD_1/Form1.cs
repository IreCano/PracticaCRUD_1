using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PracticaCRUD_1
{
    public partial class FormPractica1 : Form
    {
        public FormPractica1()
        {
            InitializeComponent();
            ClaseCrud crud = new ClaseCrud();
            dgvEmpleados.DataSource = crud.index("Empleados");
        }

        private void btnConexionBd_Click(object sender, EventArgs e)
        {
            string rutaconexion = "Server=mysql.censa.duckdns.org;User=root;Password=rootpassword;Database=sistemapos";
            MySqlConnection variableConexion = new MySqlConnection(rutaconexion);
            try
            {
                variableConexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Conectarse a la Base de Datos" + ex.Message);
                return;
            }
            variableConexion.Close();
            MessageBox.Show("Conectado Exitosamente a la Base de Datos");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseCrud crud = new ClaseCrud();
                crud.store(txtNombre.Text, txtEdad.Text,txtFechaNaci.Text);
                dgvEmpleados.DataSource = crud.index("Empleados");
                dgvEmpleados.Refresh();
            }
            catch (Exception )
            {

                MessageBox.Show("El registro ya existe");
            }
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtFechaNaci.Text = string.Empty;
           

        }
    }
    }

