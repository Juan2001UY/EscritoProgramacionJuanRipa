using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CapaDeDatos
{
    public class ModeloLogin : ModeloConexionBdd
    {
        public string NombreDeUsuario;
        public string Contraseña;
        public string NombreDeUsuarioIngresado;
        public string ContraseñaIngresada;



        public MySqlDataReader BuscarUsuario()
        {
            this.Comando.CommandText = "SELECT * FROM usuarios WHERE NombreDeUsuario = @nombredeusuario AND Contraseña = @contraseña";
            this.Comando.Parameters.AddWithValue("@nombredeusuario", this.NombreDeUsuario);
            this.Comando.Parameters.AddWithValue("@contraseña", this.Contraseña);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();

           

        }
    }
}
