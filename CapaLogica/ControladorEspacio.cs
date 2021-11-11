using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
   public class ControladorEspacio
    {
        public static void AltaEspacio(string NombreEspacio, string DescripcionEspacio)
        {
            ModeloEspacio e = new ModeloEspacio();

            e.NombreEspacio = NombreEspacio;
            e.DescripcionEspacio = DescripcionEspacio;

            e.DarAltaEspacio();
        }

        public static void BajaEspacio(int IdEspacio)
        {
            try
            {
                ModeloEspacio e = new ModeloEspacio();
                e.IdEspacio = IdEspacio;
                e.DarBajaEspacio();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ErrorCode + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("ExistenJaulasEnEsteEspacio");
                else
                    throw new Exception("ErroDesconocido");
            }

        }

        public static void ModificarEspacio(string NombreEspacio, string DescripcionEspacio, int IdEspacio)
        {
            ModeloEspacio e = new ModeloEspacio();

            e.NombreEspacio = NombreEspacio;
            e.DescripcionEspacio = DescripcionEspacio;
            e.IdEspacio = IdEspacio;

            e.ModificarEspacio();
        }

      

        public static DataTable ListarTodoEspacio()
        {
            ModeloEspacio e = new ModeloEspacio();
            DataTable tabla = new DataTable();
            tabla.Load(e.ObtenerEspacio());
            return tabla;
        }
    }
}
