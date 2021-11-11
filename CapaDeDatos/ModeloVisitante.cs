using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloVisitante : ModeloConexionBdd
    {
        public int IdVisitante;
        public string Cedula;
        public string NombreVisitante;




        private void EjecutarQuery()
        {
            try
            {
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.SqlState + " - " + ex.Message);
                if (ex.ErrorCode == -2147467259)
                    throw new Exception("YaExisteUnVisitanteConEsaCedula");
                else
                    throw new Exception("ErroDesconocido");

            }
        }

        public void DarAltaVisitante()
        {
            AgregarVisitante();
            EjecutarQuery();
        }

        public void DarBajaVisitante()
        {
            EliminarVisitante(Cedula);
            EjecutarQuery();
        }

        public void ModificarVisitante()
        {
            CambiarVisitante();
            EjecutarQuery();
        }



        private void AgregarVisitante()
        {
            this.Comando.CommandText = "INSERT INTO visitantes(Cedula,NombreVisitante) VALUES(@cedula,@nombrevisitante)";

            this.Comando.Parameters.AddWithValue("@cedula", this.Cedula);
            this.Comando.Parameters.AddWithValue("@nombrevisitante", this.NombreVisitante);
            this.Comando.Prepare();

        }



        public MySqlDataReader ObtenerVisitante()
        {
            this.Comando.CommandText = "SELECT IdVisitante, Cedula, NombreVisitante FROM visitantes WHERE IdVisitante > @numero";
            this.Comando.Parameters.AddWithValue("@numero", 0);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();
        }
    

        public void EliminarVisitante(string Cedula) {


             this.Comando.CommandText = "DELETE FROM visitantes WHERE IdVisitante = @IdAEliminar";
             this.Comando.Parameters.AddWithValue("@IdAEliminar", this.IdVisitante);
             this.Comando.Prepare();
        }


        public void CambiarVisitante()
        {
             this.Comando.CommandText = "UPDATE visitantes SET Cedula = @cedula, NombreVisitante = @nombrevisitante WHERE IdVisitante = @IdAModificar";
             this.Comando.Parameters.AddWithValue("@cedula", this.Cedula);
             this.Comando.Parameters.AddWithValue("@nombrevisitante", this.NombreVisitante);
             this.Comando.Parameters.AddWithValue("@IdAModificar", this.IdVisitante);
             this.Comando.Prepare();
        }

        }
    }
