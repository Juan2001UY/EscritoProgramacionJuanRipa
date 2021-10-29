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

        public static MySqlDataReader ObtenerVisitantes(string Cedula)
        {
            ModeloVisitante v = new ModeloVisitante();
            v.Cedula = Cedula;
            
            return v.Obtener();

        }

        public static DataTable prepararDataTable(List<ModeloVisitante> Visitantes)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Cedula");
            tabla.Columns.Add("NombreVisitante");


            foreach (ModeloVisitante Visitante in Visitantes)
                tabla.Rows.Add(Visitante.Cedula, Visitante.NombreVisitante);

            return tabla;

        }

       

        //public static DataTable Obtener(string Cedula)
        // {
        //
        //     ModeloVisitante v = new ModeloVisitante();
        //     List<ModeloVisitante> visitante = new List<ModeloVisitante>();
        //
        //      v.Obtener(Cedula);
        //     visitante.Add(v);
        //
        //     return prepararDataTable(visitante);
        //  }

        //  public static DataTable Obtener()
        // {
        //    try
        //   {
        //        ModeloVisitante v = new ModeloVisitante();
        //        List<ModeloVisitante> personas = v.Obtener();

        //         if (personas == null) throw new Exception("ResultadoVacio");
        //         return prepararDataTable(personas);
        //
        //    }
        //   catch (MySqlException ex)
        //   {
        //    Console.WriteLine(ex.SqlState + " - " + ex.Message);
        //       if (ex.SqlState == "28000")
        //         throw new Exception("AccesoNegado");
        //        else
        //            throw new Exception("ErroDesconocido");
        //
        //
        //   }
        //
        //  }
       

        


    }
}
