using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
using MySql.Data.MySqlClient;


namespace CapaLogica
{
    public class ControladorJaula
    {
        public static void AltaJaula(string DescripcionJaula, int IdUbicacion)
        {
            try
            {
                ModeloJaula j = new ModeloJaula();

                j.DescripcionJaula = DescripcionJaula;
                j.IdUbicacion = IdUbicacion;

                j.DarAltaJaula();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ErrorCode + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("NoExisteUnEspacioConEseId");
                else
                    throw new Exception("ErroDesconocido");
            }
        }

        public static void BajaJaula(int IdJaula)
        {
            try
            {
                ModeloJaula h = new ModeloJaula();
                h.IdJaula = IdJaula;
                h.DarBajaJaula();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ErrorCode + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("HayAnimalesEnLaJaula");
                else
                    throw new Exception("ErroDesconocido");
            }
        }

        public static void ModificarJaula(string DescripcionJaula, int IdUbicacion, int IdJaula)
        {
            try
            {
                ModeloJaula j = new ModeloJaula();

                j.DescripcionJaula = DescripcionJaula;
                j.IdUbicacion = IdUbicacion;
                j.IdJaula = IdJaula;

                j.ModificarJaula();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ErrorCode + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("NoExisteUnEspacioConEseId");
                else
                    throw new Exception("ErroDesconocido");
            }
        }

        public static DataTable Obtener()
        {
            ModeloJaula j = new ModeloJaula();
            DataTable tabla = new DataTable();
            tabla.Load(j.ListarJaula());
            return tabla;
        }
    }
}