using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Libreria_Web.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Servidor = "DESKTOP-MIGQ9A1";
            this.Base = "bd_registro_usuario";
            this.Usuario = "web_libreria";
            this.Clave = "12345";
        }
        public SqlConnection crearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server="+this.Servidor+
                                            "; DataBase="+this.Base+
                                            "; User Id="+this.Usuario+
                                            "; Password="+this.Clave;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion crearInstancia()
        {
            if ( Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
