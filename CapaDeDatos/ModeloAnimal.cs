using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CapaDeDatos
{
   public class ModeloAnimal : ModeloConexionBdd
    {
       
            public int IdAnimal;
            public string NombreAnimal;
            public string DescripcionAnimal;
            public int IdJ;




            private void EjecutarQuery()
            {
                this.Comando.ExecuteNonQuery();
            }

            public void DarAltaAnimal()
            {
                AgregarAnimal();
                EjecutarQuery();
            }

            public void DarBajaAnimal()
            {
                EliminarAnimal(IdAnimal);
                EjecutarQuery();
            }

            public void ModificarAnimal()
            {
                CambiarAnimal();
                EjecutarQuery();
            }



            private void AgregarAnimal()
            {
                this.Comando.CommandText = "INSERT INTO animales(NombreAnimal,DescripcionAnimal, IdJ) VALUES(@nombreanimal,@descripcionanimal, @idj)";

                this.Comando.Parameters.AddWithValue("@nombreanimal", this.NombreAnimal);
                this.Comando.Parameters.AddWithValue("@descripcionanimal", this.DescripcionAnimal);
                this.Comando.Parameters.AddWithValue("@idj", this.IdJ);
            this.Comando.Prepare();

            }
            public MySqlDataReader ListarAnimal()
            {
            this.Comando.CommandText = "SELECT IdAnimal, NombreAnimal, DescripcionAnimal, IdJ FROM animales WHERE IdAnimal > @numero";
            this.Comando.Parameters.AddWithValue("@numero", 0);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();
        }

            public void EliminarAnimal(int IdAnimal)
            {
                this.Comando.CommandText = "DELETE FROM animales WHERE IdAnimal = @IdAnimalAEliminar";
                this.Comando.Parameters.AddWithValue("@IdAnimalAEliminar", this.IdAnimal);
                this.Comando.Prepare();
            }

        public void CambiarAnimal()
        {
            this.Comando.CommandText = "UPDATE animales SET  IdJ = @idj, NombreAnimal = @nombreanimal, DescripcionAnimal = @descripcionanimal WHERE IdAnimal = @IdAnimalAModificar";
 
                this.Comando.Parameters.AddWithValue("@idj", this.IdJ);
                this.Comando.Parameters.AddWithValue("@nombreanimal", this.NombreAnimal);
                this.Comando.Parameters.AddWithValue("@@descripcionanimal", this.DescripcionAnimal);
                this.Comando.Parameters.AddWithValue("@IdAnimalAModificar", this.IdAnimal);
                this.Comando.Prepare();

        }
        }
}
