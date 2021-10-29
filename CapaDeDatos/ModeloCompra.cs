using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
   public class ModeloCompra : ModeloConexionBdd
    {
        public int IdCompra;
        public string CedulaComprador;
        public string FechaDeCompra;
        public string Producto;
        public string Precio;
        public string NombreVisitante;
        


        private void EjecutarQuery()
        {
            this.Comando.ExecuteNonQuery();
        }

        public void DarAltaVisitanteDesdeCompra()
        {
            AgregarVisitanteDesdeCompra();
            EjecutarQuery();
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

        private void AgregarVisitanteDesdeCompra()
        {
            this.Comando.CommandText = "INSERT INTO visitantes(Cedula,NombreVisitante) VALUES(@cedula,@nombrevisitante)";

            this.Comando.Parameters.AddWithValue("@cedula", this.CedulaComprador);
            this.Comando.Parameters.AddWithValue("@nombrevisitante", this.NombreVisitante);
            this.Comando.Prepare();
        }

        public MySqlDataReader BuscarVisitanteParaCompra()
        {
            this.Comando.CommandText = "SELECT Cedula FROM visitantes WHERE Cedula = @cedula";
            this.Comando.Parameters.AddWithValue("@cedula", this.CedulaComprador);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();

        }
    }
}