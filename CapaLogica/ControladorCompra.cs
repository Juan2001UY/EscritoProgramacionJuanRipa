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
            ModeloCompra c = new ModeloCompra();

            c.CedulaComprador = CedulaComprador;
            c.NombreVisitante = NombreVisitante;

            c.DarAltaVisitanteDesdeCompra();
        }

        public static MySqlDataReader ObtenerVisitanteParaCompra(string CedulaComprador)
        {
            ModeloCompra c = new ModeloCompra();
            c.CedulaComprador = CedulaComprador;

            return c.BuscarVisitanteParaCompra();
        }
    }
}
