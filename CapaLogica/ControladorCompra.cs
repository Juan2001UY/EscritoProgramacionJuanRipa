using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
   public class ControladorCompra
    {
        public static void AltaCompra(string CedulaComprador, string Producto, string Precio)
        {
            ModeloCompra c = new ModeloCompra();

            c.CedulaComprador = CedulaComprador;
            c.Producto = Producto;
            c.Precio = Precio;

            c.DarAltaCompra();
        }

        public static void AltaVisitanteDesdeCompra(string CedulaComprador, string NombreVisitante)
        {
            try
            {
                ModeloCompra c = new ModeloCompra();

                c.CedulaComprador = CedulaComprador;
                c.NombreVisitante = NombreVisitante;

                c.DarAltaVisitanteDesdeCompra();
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

        public static MySqlDataReader ObtenerVisitanteParaCompra(string CedulaComprador)
        {
            ModeloCompra c = new ModeloCompra();
            c.CedulaComprador = CedulaComprador;

            return c.BuscarVisitanteParaCompra();
        }
    }
}
