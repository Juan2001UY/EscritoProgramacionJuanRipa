using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;


namespace CapaLogica
{
    public class ControladorJaula
    {
        public static void AltaJaula(string DescripcionJaula, int IdUbicacion)
        {
            ModeloJaula j = new ModeloJaula();

            j.DescripcionJaula = DescripcionJaula;
            j.IdUbicacion = IdUbicacion;

            j.DarAltaJaula();
        }

        public static void BajaJaula(int IdJaula)
        {
            ModeloJaula h = new ModeloJaula();
            h.IdJaula = IdJaula;
            h.DarBajaJaula();

        }

        public static void ModificarJaula(string DescripcionJaula, int IdUbicacion, int IdJaula)
        {
            ModeloJaula j = new ModeloJaula();

            j.DescripcionJaula = DescripcionJaula;
            j.IdUbicacion = IdUbicacion;
            j.IdJaula = IdJaula;

            j.ModificarJaula();
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
        //     tabla.Load(v);
        //}

        public static DataTable Obtener()
        {

            ModeloJaula j = new ModeloJaula();
            List<ModeloJaula> Jaula = new List<ModeloJaula>();

            j.ListarJaula();
            Jaula.Add(j);

            return prepararDataTable(Jaula);
        }


        public static DataTable prepararDataTable(List<ModeloJaula> Jaulas)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("IdJaula");
            tabla.Columns.Add("DescripcionJaula");
            tabla.Columns.Add("IdUbicacion");

            foreach (ModeloJaula Jaula in Jaulas)
                tabla.Rows.Add(Jaula.IdJaula, Jaula.DescripcionJaula, Jaula.IdUbicacion);

            return tabla;
        }
    }
}