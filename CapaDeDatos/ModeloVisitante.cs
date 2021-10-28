﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloVisitante : ModeloConexionBdd
    {

        public string Cedula;
        public string NombreVisitante;




        private void EjecutarQuery()
        {
            this.Comando.ExecuteNonQuery();
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



        public MySqlDataReader Obtener()
        {
            this.Comando.CommandText = "SELECT Cedula,NombreVisitante FROM visitantes WHERE Cedula = @cedula";
            this.Comando.Parameters.AddWithValue("@cedula", this.Cedula);
            this.Comando.Prepare();
            return this.Comando.ExecuteReader();

            //this.lector.Read();

            //this.Cedula = lector.GetString(0);
           // this.NombreVisitante = lector.GetString(1);

        }
            public void EliminarVisitante(string Cedula) {


                this.Comando.CommandText = "DELETE FROM visitantes WHERE Cedula = @CedulaAEliminar";
                this.Comando.Parameters.AddWithValue("@CedulaAEliminar", this.Cedula);
                this.Comando.Prepare();
            }


            public void CambiarVisitante()
            {
                this.Comando.CommandText = "UPDATE visitantes SET NombreVisitante = @nombrevisitante WHERE Cedula = @CedulaAModificar";
                this.Comando.Parameters.AddWithValue("@nombrevisitante", this.NombreVisitante);
                this.Comando.Parameters.AddWithValue("@CedulaAModificar", this.Cedula);
                this.Comando.Prepare();

            }

        }
    }
