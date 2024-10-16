using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Libreria_Web.Datos;
using System.Runtime.Remoting.Messaging;

namespace Libreria_Web.Presentacion
{
    public partial class frmConectar : Form
    {
        public frmConectar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();

            sqlCon = Conexion.crearInstancia().crearConexion();

            try
            {
                sqlCon.Open();
                MessageBox.Show("Conexión Existosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexión Fallida");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
