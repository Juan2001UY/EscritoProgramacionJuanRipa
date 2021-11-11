using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloEspacio : ModeloConexionBdd
    {
        public int IdEspacio;
        public string NombreEspacio;
        public string DescripcionEspacio;




        private void EjecutarQuery()
        {
            this.Comando.ExecuteNonQuery();
        }

        public void DarAltaEspacio()
        {
            AgregarEspacio();
            EjecutarQuery();
        }

        public void DarBajaEspacio()
        {
            EliminarEspacio(IdEspacio);
            EjecutarQuery();
        }

        public void ModificarEspacio()
        {
            CambiarEspacio();
            EjecutarQuery();
        }



        private void AgregarEspacio()
        {
            this.Comando.CommandText = "INSERT INTO espacios(NombreEspacio,DescripcionEspacio) VALUES(@nombreespacio,@descripcionespacio)";

            this.Comando.Parameters.AddWithValue("@nombreespacio", this.NombreEspacio);
            this.Comando.Parameters.AddWithValue("@descripcionespacio", this.DescripcionEspacio);
            this.Comando.Prepare();

        }
        public MySqlDataReader ListarEspacio()
        {
            this.Comando.CommandText = "SELECT IdEspacio, NombreEspacio, DescripcionEspacio FROM espacios WHERE IdEspacio > @numero";
            this.Comando.Parameters.AddWithValue("@numero", 0);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();
        }

        public void EliminarEspacio(int IdEspacio)
        {
            this.Comando.CommandText = "DELETE FROM espacios WHERE IdEspacio = @IdEspacioAEliminar";
            this.Comando.Parameters.AddWithValue("@IdEspacioAEliminar", this.IdEspacio);
            this.Comando.Prepare();
        }

        public void CambiarEspacio()
        {
            this.Comando.CommandText = "UPDATE espacios SET NombreEspacio = @nombreespacio, DescripcionEspacio = @descripcionespacio WHERE IdEspacio = @IdEspacioAModificar";
            this.Comando.Parameters.AddWithValue("@nombreespacio", this.NombreEspacio);
            this.Comando.Parameters.AddWithValue("@descripcionespacio", this.DescripcionEspacio);
            this.Comando.Parameters.AddWithValue("@IdEspacioAModificar", this.IdEspacio);
            this.Comando.Prepare();

        }
    }
}
