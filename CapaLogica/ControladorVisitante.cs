using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogica
{
    public class ControladorVisitante
    {
        public static void AltaVisitante(string Cedula, string NombreVisitante)
        {
            ModeloVisitante v = new ModeloVisitante();

            v.Cedula = Cedula;
            v.NombreVisitante = NombreVisitante;

            v.DarAltaVisitante();
        }

        public static void BajaVisitante(string Cedula)
        {
            ModeloVisitante v = new ModeloVisitante();
            v.Cedula = Cedula;
            v.DarBajaVisitante();

        }

        public static void ModificarVisitante(string NombreVisitante, string Cedula)
        {
            ModeloVisitante v = new ModeloVisitante();

            v.NombreVisitante = NombreVisitante;
            v.Cedula = Cedula;
           
            v.ModificarVisitante();
        }

        //  public static void ModificacionVisitante(string Cedula, string NombreVisitante)
        // {
        //    ModeloVisitante v = new ModeloVisitante();
        //
        //    v.Cedula = Cedula;
        //     v.NombreVisitante = NombreVisitante;
        //
        //    v.ListarVisitante();

        //    DataTable tabla = new DataTable;
        //     tabla.Load(v);
        //}

        public static DataTable Obtener()
        {

            ModeloVisitante v = new ModeloVisitante();
            List<ModeloVisitante> Visitante = new List<ModeloVisitante>();

            v.ListarVisitante();
            Visitante.Add(v);

            return prepararDataTable(Visitante);
        }


        public static DataTable prepararDataTable(List<ModeloVisitante> Visitantes)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Cedula");
            tabla.Columns.Add("NombreVisitante");
           

            foreach (ModeloVisitante Visitante in Visitantes)
                tabla.Rows.Add( Visitante.Cedula , Visitante.NombreVisitante);

            return tabla;

        }


    }
}
