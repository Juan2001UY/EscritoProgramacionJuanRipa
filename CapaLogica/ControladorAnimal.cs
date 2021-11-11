using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogica
{
    public class ControladorAnimal
    {
        public static void AltaAnimal(string NombreAnimal, string DescripcionAnimal, int Idj)
        {
            ModeloAnimal a = new ModeloAnimal();

            a.NombreAnimal = NombreAnimal;
            a.DescripcionAnimal = DescripcionAnimal;
            a.IdJ = Idj;

            a.DarAltaAnimal();
        }

        public static void BajaAnimal(int IdAnimal)
        {
            ModeloAnimal a = new ModeloAnimal();
            a.IdAnimal = IdAnimal;
            a.DarBajaAnimal();

        }

        public static void ModificarAnimal(int IdJ, string NombreAnimal, string DescripcionAnimal,  int IdAnimal)
        {
            ModeloAnimal a = new ModeloAnimal();

            a.IdJ = IdJ;
            a.NombreAnimal = NombreAnimal;
            a.DescripcionAnimal = DescripcionAnimal;
            a.IdAnimal = IdAnimal;

            a.ModificarAnimal();
        }

        public static DataTable Obtener()
        {
            ModeloAnimal a = new ModeloAnimal();
            DataTable tabla = new DataTable();
            tabla.Load(a.ListarAnimal());
            return tabla;
        }
    }
}
