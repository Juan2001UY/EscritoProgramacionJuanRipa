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
            try
            {
                ModeloVisitante v = new ModeloVisitante();

                v.Cedula = Cedula;
                v.NombreVisitante = NombreVisitante;

                v.DarAltaVisitante();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ErrorCode + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("YaExisteUnVisitanteConEsaCedula");
                else
                    throw new Exception("ErroDesconocido");
            }
        }

        public static void BajaVisitante(int IdVisitante)
        {
            ModeloVisitante v = new ModeloVisitante();
            v.IdVisitante = IdVisitante;
            v.DarBajaVisitante();
        }

        public static void ModificarVisitante(string Cedula, string NombreVisitante, int IdVisitante)
        {
            try
            {
                ModeloVisitante v = new ModeloVisitante();

                v.Cedula = Cedula;
                v.NombreVisitante = NombreVisitante;
                v.IdVisitante = IdVisitante;

                v.ModificarVisitante();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ErrorCode + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("YaExisteUnVisitanteConEsaCedula");
                else
                    throw new Exception("ErroDesconocido");
            }
        } 

        public static DataTable Obtener()
        {
            ModeloVisitante v = new ModeloVisitante();
            DataTable tabla = new DataTable();
            tabla.Load(v.ObtenerVisitante());
            return tabla;
        }

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
        //   }
        //
        //  }





    }
}
