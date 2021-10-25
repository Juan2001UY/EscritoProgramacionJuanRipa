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

            ModeloAnimal a = new ModeloAnimal();
            List<ModeloAnimal> Animal = new List<ModeloAnimal>();

            a.ListarAnimal();
            Animal.Add(a);

            return prepararDataTable(Animal);
        }


        public static DataTable prepararDataTable(List<ModeloAnimal> Animales)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("IdAnimal");
            tabla.Columns.Add("NombreAnimal");
            tabla.Columns.Add("DescripcionAnimal");
            tabla.Columns.Add("IdJ");

            foreach (ModeloAnimal Animal in Animales)
                tabla.Rows.Add(Animal.IdAnimal, Animal.NombreAnimal, Animal.DescripcionAnimal, Animal.IdJ);

            return tabla;

        }
    }
}
