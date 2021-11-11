using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

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
            ModeloEspacio e = new ModeloEspacio();
            e.IdEspacio = IdEspacio;
            e.DarBajaEspacio();

        }

        public static void ModificarEspacio(string NombreEspacio, string DescripcionEspacio, int IdEspacio)
        {
            ModeloEspacio e = new ModeloEspacio();

            e.NombreEspacio = NombreEspacio;
            e.DescripcionEspacio = DescripcionEspacio;
            e.IdEspacio = IdEspacio;

            e.ModificarEspacio();
        }

      

        public static DataTable Obtener()
        {
            ModeloEspacio e = new ModeloEspacio();
            DataTable tabla = new DataTable();
            tabla.Load(e.ListarEspacio());
            return tabla;
        }
    }
}
