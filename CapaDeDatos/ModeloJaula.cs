using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
   public class ModeloJaula : ModeloConexionBdd
    {
        public int IdJaula;
        public string DescripcionJaula;
        public int IdUbicacion;

        private void EjecutarQuery()
        {
            this.Comando.ExecuteNonQuery();
        }

        public void DarAltaJaula()
        {
            AgregarJaula();
            EjecutarQuery();
        }

        public void DarBajaJaula()
        {
            EliminarJaula(IdJaula);
            EjecutarQuery();
        }

        public void ModificarJaula()
        {
            CambiarJaula();
            EjecutarQuery();
        }



        private void AgregarJaula()
        {
            this.Comando.CommandText = "INSERT INTO jaulas(DescripcionJaula, IdUbicacion ) VALUES(@descripcionjaula, @idubicacion)";

            this.Comando.Parameters.AddWithValue("@descripcionjaula", this.DescripcionJaula);
            this.Comando.Parameters.AddWithValue("@idubicacion", this.IdUbicacion);
            this.Comando.Prepare();

        }
        public MySqlDataReader ListarJaula()
        {
            this.Comando.CommandText = "SELECT IdJaula, DescripcionJaula, IdUbicacion FROM jaulas WHERE IdJaula > @numero";
            this.Comando.Parameters.AddWithValue("@numero", 0);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();
            // this.lector = this.Comando.ExecuteReader();

            // this.lector.Read();

            // this.IdJaula = lector.GetInt32(0);
            //this.DescripcionJaula = lector.GetString(1);
            //this.IdUbicacion = lector.GetInt32(2);

        }

        public void EliminarJaula(int IdEspacio)
        {
            this.Comando.CommandText = "DELETE FROM jaulas WHERE IdJaula = @IdJaulaAEliminar";
            this.Comando.Parameters.AddWithValue("@IdJaulaAEliminar", this.IdJaula);
            this.Comando.Prepare();
        }

        public void CambiarJaula()
        {
            this.Comando.CommandText = "UPDATE jaulas SET  DescripcionJaula = @descripcionjaula, IdUbicacion = @idubicacion WHERE IdJaula = @IdJaulaAModificar";

            this.Comando.Parameters.AddWithValue("@descripcionjaula", this.DescripcionJaula);
            this.Comando.Parameters.AddWithValue("@@idubicacion", this.IdUbicacion);
            this.Comando.Parameters.AddWithValue("@IdJaulaAModificar", this.IdJaula);
            this.Comando.Prepare();
        }
    }
}
