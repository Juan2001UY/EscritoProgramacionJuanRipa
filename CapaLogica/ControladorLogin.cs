using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using MySql.Data.MySqlClient;


namespace CapaLogica
{
    public class ControladorLogin
    {
            public static MySqlDataReader ObtenerUsuario(string NombreDeUsuario, string Contraseña)
            {
                ModeloLogin l = new ModeloLogin();
                l.NombreDeUsuario = NombreDeUsuario;
                l.Contraseña = Contraseña;

                return l.BuscarUsuario();

            }
    }
}