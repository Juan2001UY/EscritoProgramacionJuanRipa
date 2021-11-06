using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloConexionBdd
    {
        protected string IpBaseDeDatos;
        protected string UsuarioBaseDeDatos;
        protected string PasswordDeDatos;
        protected string NombreBaseDeDatos;
        public MySqlConnection Conexion;
        protected MySqlCommand Comando;
        protected MySqlDataReader lector;


        public ModeloConexionBdd()
        {
            this.InicializarConexión();
            Conexion = new MySqlConnection(
          "server=" + this.IpBaseDeDatos + ";" +
          "userid=" + this.UsuarioBaseDeDatos + ";" +
          "password=" + this.PasswordDeDatos + ";" +
          "database=" + this.NombreBaseDeDatos + ";"
                      );

            Conexion.Open();
            this.Comando = new MySqlCommand();
            this.Comando.Connection = this.Conexion;
        }

        public void InicializarConexión()
        {
            this.IpBaseDeDatos = "localhost";
            this.UsuarioBaseDeDatos = "root";
            this.PasswordDeDatos = "Juan2001";
            this.NombreBaseDeDatos = "baseprog";
        }
    }
}
