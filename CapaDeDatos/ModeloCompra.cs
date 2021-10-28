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
        public string Precio;


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
            this.Comando.CommandText = "INSERT INTO compras(CedulaComprador,Producto,Precio) VALUES(@cedulacomprador,@producto,@precio)";

            this.Comando.Parameters.AddWithValue("@cedulacomprador", this.CedulaComprador);
            this.Comando.Parameters.AddWithValue("@producto", this.Producto);
            this.Comando.Parameters.AddWithValue("@precio", this.Precio);
            this.Comando.Prepare();
        }
    }
}