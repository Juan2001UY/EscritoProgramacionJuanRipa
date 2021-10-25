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

        //  public static void ModificacionEspacio(int IdEspacio, string NombreEspacio, string DescripcionEspacio)
        // {
        //    ModeloEspacio e = new ModeloEspacio();
        //
        //    e.Cedula = Cedula;
        //    e.NombreEspacio = NombreEspacio;
        //    e.DescripcionEspacio = DescripcionEspacio;
        //
        //    e.ListarEspacio();

        //    DataTable tabla = new DataTable;
        //     tabla.Load(e);
        //}

        public static DataTable Obtener()
        {

            ModeloEspacio e = new ModeloEspacio();
            List<ModeloEspacio> Espacio = new List<ModeloEspacio>();

            e.ListarEspacio();
            Espacio.Add(e);

            return prepararDataTable(Espacio);
        }


        public static DataTable prepararDataTable(List<ModeloEspacio> Espacios)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("IdEspacio");
            tabla.Columns.Add("NombreEspacio");
            tabla.Columns.Add("DescripcionEspacio");

            foreach (ModeloEspacio Espacio in Espacios)
                tabla.Rows.Add(Espacio.IdEspacio, Espacio.NombreEspacio, Espacio.DescripcionEspacio);

            return tabla;

        }
    }
}
