using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
   public class ModeloCompra : ModeloConexionBdd
    {
        public int IdCompra;
        public string CedulaComprador;
        public string FechaDeCompra;
        public string Producto;


        private void EjecutarQuery()
        {
            this.Comando.ExecuteNonQuery();
        }

        public void DarAltaCompra()
        {
            AgregarCompra();
            EjecutarQuery();
        }

        private void AgregarCompra()
        {
            this.Comando.CommandText = "INSERT INTO compras(CedulaComprador,Producto) VALUES(@cedulacomprador,@producto)";

            this.Comando.Parameters.AddWithValue("@cedulacomprador", this.CedulaComprador);
            this.Comando.Parameters.AddWithValue("@producto", this.Producto);
            this.Comando.Prepare();
        }
    }
}