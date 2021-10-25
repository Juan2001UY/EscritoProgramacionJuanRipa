using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ListarJaula()
        {
            this.Comando.CommandText = "SELECT * FROM jaulas";
            lector = this.Comando.ExecuteReader();

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
